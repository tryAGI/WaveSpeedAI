/*
order: 20
title: Video Generation
slug: video-generation

Generate videos using Wan 2.1 models.
*/

namespace WaveSpeedAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_TextToVideo480p()
    {
        using var client = GetAuthenticatedClient();

        //// Generate a 480p video from a text prompt using Wan 2.1
        var response = await client.VideoGeneration.GenerateWanTextToVideo480pAsync(
            prompt: "A cat sitting on a windowsill watching rain");

        response.Value1?.Code.Should().Be(200);
        response.Value2?.Data?.Id.Should().NotBeNullOrEmpty();

        Console.WriteLine($"Task ID: {response.Value2?.Data?.Id}");
        Console.WriteLine($"Status: {response.Value2?.Data?.Status}");
    }

    [TestMethod]
    public async Task Example_ImageToVideo720p()
    {
        using var client = GetAuthenticatedClient();

        //// Generate a 720p video from an image using Wan 2.1 image-to-video
        var response = await client.VideoGeneration.GenerateWanImageToVideo720pAsync(
            prompt: "The scene slowly comes to life with gentle wind movement",
            image: "https://example.com/source-image.jpg");

        response.Value1?.Code.Should().Be(200);
        Console.WriteLine($"Task ID: {response.Value2?.Data?.Id}");
    }
}
