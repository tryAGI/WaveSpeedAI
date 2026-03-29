
#nullable enable

namespace WaveSpeedAI
{
    /// <summary>
    /// Classification of the uploaded file.
    /// </summary>
    public enum UploadDataType
    {
        /// <summary>
        /// 
        /// </summary>
        Audio,
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UploadDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadDataType value)
        {
            return value switch
            {
                UploadDataType.Audio => "audio",
                UploadDataType.Image => "image",
                UploadDataType.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadDataType? ToEnum(string value)
        {
            return value switch
            {
                "audio" => UploadDataType.Audio,
                "image" => UploadDataType.Image,
                "video" => UploadDataType.Video,
                _ => null,
            };
        }
    }
}