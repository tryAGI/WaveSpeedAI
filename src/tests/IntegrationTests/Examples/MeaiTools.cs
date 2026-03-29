/*
order: 40
title: MEAI Tools
slug: meai-tools

Shows how to use WaveSpeedAI AIFunction tools with any IChatClient.
*/

namespace WaveSpeedAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void AsGenerateImageTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create an image generation tool from the WaveSpeedAI client for use with any IChatClient.
        var tool = client.AsGenerateImageTool(
            modelId: "wavespeed-ai/flux-dev",
            size: "1024*1024",
            numImages: 1);
        tool.Name.Should().Be("GenerateImage");
        tool.Description.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public void AsGenerateVideoTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a video generation tool for producing videos from text prompts.
        var tool = client.AsGenerateVideoTool(
            modelId: "wavespeed-ai/wan-2.1/wan-2.1-t2v-480p");
        tool.Name.Should().Be("GenerateVideo");
        tool.Description.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public void AsGetTaskResultTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a task status tool for checking generation progress.
        var tool = client.AsGetTaskResultTool();
        tool.Name.Should().Be("GetTaskResult");
        tool.Description.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public void AsListPredictionsTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a predictions listing tool for browsing generation history.
        var tool = client.AsListPredictionsTool();
        tool.Name.Should().Be("ListPredictions");
        tool.Description.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public void CombineAllTools()
    {
        using var client = GetAuthenticatedClient();

        //// Combine all tools for full generation and status-checking capabilities.
        var tools = new[]
        {
            client.AsGenerateImageTool(),
            client.AsGenerateVideoTool(),
            client.AsGetTaskResultTool(),
            client.AsListPredictionsTool(),
        };

        tools.Should().HaveCount(4);
        tools.Select(t => t.Name).Should().OnlyHaveUniqueItems();
    }
}
