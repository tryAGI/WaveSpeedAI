namespace WaveSpeedAI.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static WaveSpeedAIClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("WAVESPEEDAI_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("WAVESPEEDAI_API_KEY environment variable is not found.");

        var client = new WaveSpeedAIClient(apiKey);
        
        return client;
    }
}
