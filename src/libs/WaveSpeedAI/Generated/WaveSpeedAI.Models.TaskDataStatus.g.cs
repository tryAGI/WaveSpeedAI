
#nullable enable

namespace WaveSpeedAI
{
    /// <summary>
    /// Current task status.
    /// </summary>
    public enum TaskDataStatus
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
    public static class TaskDataStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TaskDataStatus value)
        {
            return value switch
            {
                TaskDataStatus.Completed => "completed",
                TaskDataStatus.Created => "created",
                TaskDataStatus.Failed => "failed",
                TaskDataStatus.Processing => "processing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TaskDataStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => TaskDataStatus.Completed,
                "created" => TaskDataStatus.Created,
                "failed" => TaskDataStatus.Failed,
                "processing" => TaskDataStatus.Processing,
                _ => null,
            };
        }
    }
}