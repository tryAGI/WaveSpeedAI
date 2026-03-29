# CLAUDE.md -- WaveSpeedAI SDK

## Overview

Auto-generated C# SDK for [WaveSpeed AI](https://wavespeed.ai/) -- multi-model generation platform with 700+ AI models for image, video, and audio generation. Provides a unified REST API for models from WaveSpeed AI, Google, OpenAI, ByteDance, and 30+ other providers.
**No public OpenAPI spec exists** -- `openapi.yaml` was manually created from WaveSpeed AI API documentation.

## Build & Test

```bash
dotnet build WaveSpeedAI.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

Bearer token auth:

```csharp
var client = new WaveSpeedAIClient(apiKey); // WAVESPEEDAI_API_KEY env var
```

Base URL: `https://api.wavespeed.ai/api/v3`

## Key Files

- `src/libs/WaveSpeedAI/openapi.yaml` -- **Manually maintained** OpenAPI spec (no public spec from WaveSpeed AI)
- `src/libs/WaveSpeedAI/generate.sh` -- Runs autosdk on local spec (no download step)
- `src/libs/WaveSpeedAI/Generated/` -- **Never edit** -- auto-generated code
- `src/libs/WaveSpeedAI/Extensions/WaveSpeedAIClient.Tools.cs` -- MEAI `AIFunction` tools (GenerateImage, GenerateVideo, GetTaskResult, ListPredictions)
- `src/tests/IntegrationTests/Tests.cs` -- Test helper with bearer auth
- `src/tests/IntegrationTests/Examples/` -- Example tests (also generate docs)

## Spec Notes

- **No public OpenAPI spec exists** -- `openapi.yaml` was manually created from WaveSpeed AI API docs
- All generation endpoints follow an async task pattern: POST creates a task, GET polls for status (created, processing, completed, failed)
- The generic `/{modelId}` endpoint supports any of 700+ models using the `{provider}/{model-name}` format
- Named endpoints exist for popular models (FLUX Dev, FLUX Schnell, FLUX Dev Ultra, FLUX Dev Fast, Wan 2.1 T2V/I2V)
- Media upload endpoint for images/videos/audio at `/media/upload/binary`
- Predictions history at `/predictions` with pagination and filtering

## Async Task Pattern

Two-step generation workflow:
1. **Create:** `client.Predictions.CreatePredictionAsync(modelId, prompt, ...)` -- returns `TaskResponse` with `TaskId` and `Status`
2. **Poll:** `client.Predictions.GetTaskResultAsync(taskId)` -- check `Status` (`created` -> `processing` -> `completed`), then access output URLs from `Outputs`

Same pattern applies to all generation endpoints (image, video, generic).

## Sub-Client Pattern

The client exposes sub-clients for organized access:
- `client.ImageGeneration` -- FLUX Dev, FLUX Schnell, FLUX Dev Ultra, FLUX Dev Fast
- `client.VideoGeneration` -- Wan 2.1 T2V 480p/720p, Wan 2.1 I2V 480p/720p
- `client.Predictions` -- Generic model endpoint, task results, prediction history
- `client.Media` -- File upload

## MEAI Integration

AIFunction tools for use with any `IChatClient`:
- `AsGenerateImageTool(modelId, size, numImages)` -- Generate images from text prompt
- `AsGenerateVideoTool(modelId)` -- Generate videos from text prompt
- `AsGetTaskResultTool()` -- Get task status and output URLs
- `AsListPredictionsTool()` -- List recent prediction history

No MEAI interface (`IChatClient`, `IEmbeddingGenerator`, `ISpeechToTextClient`) is implemented -- WaveSpeed AI is an image/video generation platform with no matching MEAI interface.

## Endpoints

| Endpoint | Method | Description |
|----------|--------|-------------|
| `/{modelId}` | POST | Create prediction with any of 700+ models |
| `/predictions/{taskId}/result` | GET | Get task result / poll for status |
| `/predictions` | POST | List prediction history with pagination |
| `/media/upload/binary` | POST | Upload media file (image/video/audio) |
| `/wavespeed-ai/flux-dev` | POST | Generate image with FLUX Dev |
| `/wavespeed-ai/flux-schnell` | POST | Generate image with FLUX Schnell |
| `/wavespeed-ai/flux-dev-ultra` | POST | Generate image with FLUX Dev Ultra |
| `/wavespeed-ai/flux-dev-fast` | POST | Generate image with FLUX Dev Fast |
| `/wavespeed-ai/wan-2.1/wan-2.1-t2v-480p` | POST | Text-to-video 480p with Wan 2.1 |
| `/wavespeed-ai/wan-2.1/wan-2.1-t2v-720p` | POST | Text-to-video 720p with Wan 2.1 |
| `/wavespeed-ai/wan-2.1/wan-2.1-i2v-480p` | POST | Image-to-video 480p with Wan 2.1 |
| `/wavespeed-ai/wan-2.1/wan-2.1-i2v-720p` | POST | Image-to-video 720p with Wan 2.1 |
