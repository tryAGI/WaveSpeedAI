# WaveSpeedAI

[![Nuget package](https://img.shields.io/nuget/vpre/WaveSpeedAI)](https://www.nuget.org/packages/WaveSpeedAI/)
[![dotnet](https://github.com/tryAGI/WaveSpeedAI/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/tryAGI/WaveSpeedAI/actions/workflows/dotnet.yml)
[![License: MIT](https://img.shields.io/github/license/tryAGI/WaveSpeedAI)](https://github.com/tryAGI/WaveSpeedAI/blob/main/LICENSE.txt)
[![Discord](https://img.shields.io/discord/1115206893015662663?label=Discord&logo=discord&logoColor=white&color=d82679)](https://discord.gg/Ca2xhfBf3v)

## Features
- Fully generated C# SDK for [WaveSpeed AI](https://wavespeed.ai/) using [AutoSDK](https://github.com/HavenDV/AutoSDK)
- Multi-model generation platform with 700+ AI models for image, video, and audio generation
- Typed FLUX Dev/Schnell/Ultra image generation endpoints
- Typed Wan 2.1 text-to-video and image-to-video endpoints
- Generic prediction endpoint supporting any model on the platform
- MEAI `AIFunction` tools for use with any `IChatClient`
- All modern .NET features - nullability, trimming, NativeAOT, etc.

### Usage
```csharp
using WaveSpeedAI;

using var client = new WaveSpeedAIClient(apiKey);
```

<!-- EXAMPLES:START -->
<!-- EXAMPLES:END -->

## Support

Priority place for bugs: https://github.com/tryAGI/WaveSpeedAI/issues  
Priority place for ideas and general questions: https://github.com/tryAGI/WaveSpeedAI/discussions  
Discord: https://discord.gg/Ca2xhfBf3v  

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).
