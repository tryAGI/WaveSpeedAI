/*
order: 10
title: Image Generation
slug: image-generation

Generate images using FLUX models with various options.
*/

namespace WaveSpeedAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_FluxDev()
    {
        using var client = GetAuthenticatedClient();

        //// Generate an image using FLUX Dev with custom parameters
        var response = await client.ImageGeneration.GenerateFluxDevAsync(
            prompt: "A futuristic cityscape with neon lights, cyberpunk style",
            size: "1024*1024",
            numInferenceSteps: 28,
            guidanceScale: 3.5,
            numImages: 1,
            outputFormat: ImageGenerationRequestOutputFormat.Png,
            enableSyncMode: true);

        response.Value1?.Code.Should().Be(200);
        Console.WriteLine($"Task ID: {response.Value2?.Data?.Id}");
    }

    [TestMethod]
    public async Task Example_FluxSchnell()
    {
        using var client = GetAuthenticatedClient();

        //// Generate an image using the fast FLUX Schnell model
        var response = await client.ImageGeneration.GenerateFluxSchnellAsync(
            prompt: "A golden retriever playing in autumn leaves",
            enableSyncMode: true);

        response.Value1?.Code.Should().Be(200);
    }
}
