
#nullable enable

namespace WaveSpeedAI
{
    /// <summary>
    /// Output video file format.<br/>
    /// Default Value: mp4
    /// </summary>
    public enum VideoGenerationRequestOutputFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Gif,
        /// <summary>
        /// 
        /// </summary>
        Mp4,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoGenerationRequestOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoGenerationRequestOutputFormat value)
        {
            return value switch
            {
                VideoGenerationRequestOutputFormat.Gif => "gif",
                VideoGenerationRequestOutputFormat.Mp4 => "mp4",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoGenerationRequestOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "gif" => VideoGenerationRequestOutputFormat.Gif,
                "mp4" => VideoGenerationRequestOutputFormat.Mp4,
                _ => null,
            };
        }
    }
}