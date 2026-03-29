
#nullable enable

namespace WaveSpeedAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UploadData
    {
        /// <summary>
        /// Classification of the uploaded file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::WaveSpeedAI.JsonConverters.UploadDataTypeJsonConverter))]
        public global::WaveSpeedAI.UploadDataType? Type { get; set; }

        /// <summary>
        /// URL for use in generation requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("download_url")]
        public string? DownloadUrl { get; set; }

        /// <summary>
        /// Original filename.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// File size in bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public long? Size { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadData" /> class.
        /// </summary>
        /// <param name="type">
        /// Classification of the uploaded file.
        /// </param>
        /// <param name="downloadUrl">
        /// URL for use in generation requests.
        /// </param>
        /// <param name="filename">
        /// Original filename.
        /// </param>
        /// <param name="size">
        /// File size in bytes.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UploadData(
            global::WaveSpeedAI.UploadDataType? type,
            string? downloadUrl,
            string? filename,
            long? size)
        {
            this.Type = type;
            this.DownloadUrl = downloadUrl;
            this.Filename = filename;
            this.Size = size;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadData" /> class.
        /// </summary>
        public UploadData()
        {
        }
    }
}