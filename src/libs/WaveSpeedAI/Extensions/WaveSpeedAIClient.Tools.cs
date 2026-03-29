#pragma warning disable CS3002 // Return type is not CLS-compliant
using Microsoft.Extensions.AI;

namespace WaveSpeedAI;

/// <summary>
/// Extensions for using WaveSpeedAIClient as MEAI tools with any IChatClient.
/// </summary>
public static class WaveSpeedAIToolExtensions
{
    /// <summary>
    /// Creates an <see cref="AIFunction"/> that generates an image from a text prompt
    /// using any model on the WaveSpeed AI platform. Returns the created task ID and status.
    /// </summary>
    /// <param name="client">The WaveSpeedAI client to use for generation.</param>
    /// <param name="modelId">Model identifier (default: wavespeed-ai/flux-dev).</param>
    /// <param name="size">Output dimensions in width*height format (default: 1024*1024).</param>
    /// <param name="numImages">Number of images to generate (default: 1).</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsGenerateImageTool(
        this WaveSpeedAIClient client,
        string modelId = "wavespeed-ai/flux-dev",
        string size = "1024*1024",
        int numImages = 1)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string prompt, CancellationToken cancellationToken) =>
            {
                var response = await client.Predictions.CreatePredictionAsync(
                    modelId: modelId,
                    prompt: prompt,
                    size: size,
                    numImages: numImages,
                    enableSyncMode: true,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatTaskResponse(response, "image generation");
            },
            name: "GenerateImage",
            description: "Generates images from a text description using WaveSpeed AI. Provide a detailed prompt describing the desired image content, style, and composition. Returns the task status and output URLs when complete.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that generates a video from a text prompt
    /// using any model on the WaveSpeed AI platform. Returns the created task ID and status.
    /// </summary>
    /// <param name="client">The WaveSpeedAI client to use for generation.</param>
    /// <param name="modelId">Model identifier (default: wavespeed-ai/wan-2.1/wan-2.1-t2v-480p).</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsGenerateVideoTool(
        this WaveSpeedAIClient client,
        string modelId = "wavespeed-ai/wan-2.1/wan-2.1-t2v-480p")
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string prompt, CancellationToken cancellationToken) =>
            {
                var response = await client.Predictions.CreatePredictionAsync(
                    modelId: modelId,
                    prompt: prompt,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatTaskResponse(response, "video generation");
            },
            name: "GenerateVideo",
            description: "Generates a video from a text description using WaveSpeed AI. Provide a detailed prompt describing the desired video content, motion, and style. Returns a task ID that can be used to check generation status.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that retrieves the status and result
    /// of a generation task by its ID.
    /// </summary>
    /// <param name="client">The WaveSpeedAI client to use.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsGetTaskResultTool(this WaveSpeedAIClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string taskId, CancellationToken cancellationToken) =>
            {
                var response = await client.Predictions.GetTaskResultAsync(
                    taskId: taskId,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatTaskResponse(response, "task result");
            },
            name: "GetTaskResult",
            description: "Retrieves the status and result of a generation task by its task ID. Returns the task status (created, processing, completed, failed) and output URLs when complete. Use this to poll for task completion after submitting a generation request.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that lists recent prediction history
    /// with optional filtering by model and status.
    /// </summary>
    /// <param name="client">The WaveSpeedAI client to use.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsListPredictionsTool(this WaveSpeedAIClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (int? page, int? pageSize, string? model, CancellationToken cancellationToken) =>
            {
                var response = await client.Predictions.ListPredictionsAsync(
                    page: page ?? 1,
                    pageSize: pageSize ?? 20,
                    model: model,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatPredictionListResponse(response);
            },
            name: "ListPredictions",
            description: "Lists recent prediction history from the WaveSpeed AI platform. Returns a paginated list of predictions with their status, model, and output URLs. Supports filtering by model identifier. Only data from the past 7 days is available.");
    }

    private static string FormatTaskResponse(TaskResponse response, string taskType)
    {
        var parts = new List<string>();
        var code = response.Value1?.Code;
        var message = response.Value1?.Message;
        var data = response.Value2?.Data;

        if (code == 200)
        {
            if (data is { } taskData)
            {
                if (!string.IsNullOrWhiteSpace(taskData.Id))
                {
                    parts.Add($"Task ID: {taskData.Id}");
                }
                if (taskData.Status is { } status)
                {
                    parts.Add($"Status: {status.ToValueString()}");
                }

                if (taskData.Status == TaskDataStatus.Completed && taskData.Outputs is { Count: > 0 })
                {
                    parts.Add($"Task completed ({taskType}).");
                    parts.Add("Outputs:");
                    foreach (var output in taskData.Outputs)
                    {
                        parts.Add($"- {output}");
                    }
                }
                else if (taskData.Status == TaskDataStatus.Failed)
                {
                    parts.Add($"Task failed ({taskType}).");
                    if (!string.IsNullOrWhiteSpace(taskData.Error))
                    {
                        parts.Add($"Error: {taskData.Error}");
                    }
                }
                else
                {
                    parts.Add($"Task in progress ({taskType}).");
                }

                if (taskData.Timings is { Inference: > 0 } timings)
                {
                    parts.Add($"Inference time: {timings.Inference}ms");
                }
            }
        }
        else
        {
            parts.Add($"Request failed ({taskType}).");
            if (!string.IsNullOrWhiteSpace(message))
            {
                parts.Add($"Error: {message}");
            }
        }

        return string.Join("\n", parts);
    }

    private static string FormatPredictionListResponse(PredictionListResponse response)
    {
        var parts = new List<string>();
        var code = response.Value1?.Code;
        var message = response.Value1?.Message;
        var data = response.Value2?.Data;

        if (code == 200 && data is { } listData)
        {
            parts.Add($"Page: {listData.Page}");
            if (listData.Items is { Count: > 0 })
            {
                parts.Add($"Predictions ({listData.Items.Count}):");
                foreach (var item in listData.Items)
                {
                    var entry = $"- [{item.Status?.ToValueString() ?? "unknown"}] {item.Model ?? "unknown model"}";
                    if (!string.IsNullOrWhiteSpace(item.Id))
                    {
                        entry += $" (ID: {item.Id})";
                    }
                    if (item.Outputs is { Count: > 0 })
                    {
                        entry += $" - {item.Outputs.Count} output(s)";
                    }
                    parts.Add(entry);
                }
            }
            else
            {
                parts.Add("No predictions found.");
            }
        }
        else
        {
            parts.Add("Failed to list predictions.");
            if (!string.IsNullOrWhiteSpace(message))
            {
                parts.Add($"Error: {message}");
            }
        }

        return string.Join("\n", parts);
    }
}
