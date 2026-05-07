#nullable enable
#pragma warning disable CS1591

namespace WaveSpeedAI;

public readonly partial struct TaskResponse
{
    public ApiResponse? Value1 => Api;

    public TaskResponseVariant2? Value2 => TaskResponseVariant2;
}

public readonly partial struct PredictionListResponse
{
    public ApiResponse? Value1 => Api;

    public PredictionListResponseVariant2? Value2 => PredictionListResponseVariant2;
}
