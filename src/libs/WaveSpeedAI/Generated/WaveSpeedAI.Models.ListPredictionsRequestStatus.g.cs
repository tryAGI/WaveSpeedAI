
#nullable enable

namespace WaveSpeedAI
{
    /// <summary>
    /// Filter by task status.
    /// </summary>
    public enum ListPredictionsRequestStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
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
    public static class ListPredictionsRequestStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListPredictionsRequestStatus value)
        {
            return value switch
            {
                ListPredictionsRequestStatus.Completed => "completed",
                ListPredictionsRequestStatus.Failed => "failed",
                ListPredictionsRequestStatus.Processing => "processing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListPredictionsRequestStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ListPredictionsRequestStatus.Completed,
                "failed" => ListPredictionsRequestStatus.Failed,
                "processing" => ListPredictionsRequestStatus.Processing,
                _ => null,
            };
        }
    }
}