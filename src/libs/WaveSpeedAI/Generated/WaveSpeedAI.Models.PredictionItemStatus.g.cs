
#nullable enable

namespace WaveSpeedAI
{
    /// <summary>
    /// Prediction status.
    /// </summary>
    public enum PredictionItemStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Created,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Processing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PredictionItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PredictionItemStatus value)
        {
            return value switch
            {
                PredictionItemStatus.Completed => "completed",
                PredictionItemStatus.Created => "created",
                PredictionItemStatus.Failed => "failed",
                PredictionItemStatus.Processing => "processing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PredictionItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => PredictionItemStatus.Completed,
                "created" => PredictionItemStatus.Created,
                "failed" => PredictionItemStatus.Failed,
                "processing" => PredictionItemStatus.Processing,
                _ => null,
            };
        }
    }
}