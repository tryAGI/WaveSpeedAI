# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The WaveSpeed AI SDK provides `AIFunction` tool wrappers compatible with [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai). These tools can be used with any `IChatClient` to give AI models access to WaveSpeed AI's image and video generation from 700+ models, task result polling, and prediction history.

## Installation

```bash
dotnet add package WaveSpeedAI
```

## Available Tools

| Method | Tool Name | Description |
|--------|-----------|-------------|
| `AsGenerateImageTool()` | `GenerateImage` | Generate images from text prompts using FLUX, Stable Diffusion, and other models |
| `AsGenerateVideoTool()` | `GenerateVideo` | Generate videos from text prompts using Wan 2.1 and other models |
| `AsGetTaskResultTool()` | `GetTaskResult` | Poll task status and retrieve output URLs when complete |
| `AsListPredictionsTool()` | `ListPredictions` | List recent prediction history with optional model filtering |

## Usage

```csharp
using WaveSpeedAI;
using Microsoft.Extensions.AI;

var wavespeedClient = new WaveSpeedAIClient(
    apiKey: Environment.GetEnvironmentVariable("WAVESPEEDAI_API_KEY")!);

var options = new ChatOptions
{
    Tools =
    [
        wavespeedClient.AsGenerateImageTool(),
        wavespeedClient.AsGenerateVideoTool(),
        wavespeedClient.AsGetTaskResultTool(),
        wavespeedClient.AsListPredictionsTool(),
    ],
};

IChatClient chatClient = /* your chat client */;

var messages = new List<ChatMessage>
{
    new(ChatRole.User, "Generate an image of a futuristic cityscape at sunset."),
};

while (true)
{
    var response = await chatClient.GetResponseAsync(messages, options);
    messages.AddRange(response.ToChatMessages());

    if (response.FinishReason == ChatFinishReason.ToolCalls)
    {
        var results = await response.CallToolsAsync(options);
        messages.AddRange(results);
        continue;
    }

    Console.WriteLine(response.Text);
    break;
}
```
