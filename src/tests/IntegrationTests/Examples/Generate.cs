/*
order: 1
title: Getting Started
slug: getting-started

Create a WaveSpeedAI client and submit a generation task.
*/

namespace WaveSpeedAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_GenerateImage()
    {
        using var client = GetAuthenticatedClient();

        //// Generate an image using the generic prediction endpoint with FLUX Dev model
        var response = await client.Predictions.CreatePredictionAsync(
            modelId: "wavespeed-ai/flux-dev",
            prompt: "A cat wearing a space suit, cinematic lighting",
            size: "1024*1024",
            numImages: 1,
            enableSyncMode: true);

        response.Value1?.Code.Should().Be(200);

        Console.WriteLine($"Task ID: {response.Value2?.Data?.Id}");
        Console.WriteLine($"Status: {response.Value2?.Data?.Status}");
        if (response.Value2?.Data?.Outputs is { Count: > 0 } outputs)
        {
            foreach (var output in outputs)
            {
                Console.WriteLine($"Output: {output}");
            }
        }
    }

    [TestMethod]
    public async Task Example_GetTaskResult()
    {
        using var client = GetAuthenticatedClient();

        //// Submit a generation task
        var createResponse = await client.Predictions.CreatePredictionAsync(
            modelId: "wavespeed-ai/flux-schnell",
            prompt: "A serene mountain landscape at sunset");

        var taskId = createResponse.Value2?.Data?.Id;
        taskId.Should().NotBeNullOrEmpty();

        //// Poll for the result until completed
        var result = await client.Predictions.GetTaskResultAsync(
            taskId: taskId!);

        Console.WriteLine($"Status: {result.Value2?.Data?.Status}");
    }
}
