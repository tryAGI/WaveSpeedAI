
#nullable enable

namespace WaveSpeedAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoGenerationRequest
    {
        /// <summary>
        /// Text description of the video to generate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Source image URL for image-to-video generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public string? Image { get; set; }

        /// <summary>
        /// Output video dimensions in pixels (width*height format).<br/>
        /// Default Value: 1280*720
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public string? Size { get; set; }

        /// <summary>
        /// Number of inference iterations.<br/>
        /// Default Value: 30
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_inference_steps")]
        public int? NumInferenceSteps { get; set; }

        /// <summary>
        /// Random seed. Use -1 for random generation.<br/>
        /// Default Value: -1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Prompt adherence strength.<br/>
        /// Default Value: 5.0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guidance_scale")]
        public double? GuidanceScale { get; set; }

        /// <summary>
        /// Output video file format.<br/>
        /// Default Value: mp4
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::WaveSpeedAI.JsonConverters.VideoGenerationRequestOutputFormatJsonConverter))]
        public global::WaveSpeedAI.VideoGenerationRequestOutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// Wait for result before returning the response.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_sync_mode")]
        public bool? EnableSyncMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoGenerationRequest" /> class.
        /// </summary>
        /// <param name="prompt">
        /// Text description of the video to generate.
        /// </param>
        /// <param name="image">
        /// Source image URL for image-to-video generation.
        /// </param>
        /// <param name="size">
        /// Output video dimensions in pixels (width*height format).<br/>
        /// Default Value: 1280*720
        /// </param>
        /// <param name="numInferenceSteps">
        /// Number of inference iterations.<br/>
        /// Default Value: 30
        /// </param>
        /// <param name="seed">
        /// Random seed. Use -1 for random generation.<br/>
        /// Default Value: -1
        /// </param>
        /// <param name="guidanceScale">
        /// Prompt adherence strength.<br/>
        /// Default Value: 5.0
        /// </param>
        /// <param name="outputFormat">
        /// Output video file format.<br/>
        /// Default Value: mp4
        /// </param>
        /// <param name="enableSyncMode">
        /// Wait for result before returning the response.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoGenerationRequest(
            string prompt,
            string? image,
            string? size,
            int? numInferenceSteps,
            int? seed,
            double? guidanceScale,
            global::WaveSpeedAI.VideoGenerationRequestOutputFormat? outputFormat,
            bool? enableSyncMode)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Image = image;
            this.Size = size;
            this.NumInferenceSteps = numInferenceSteps;
            this.Seed = seed;
            this.GuidanceScale = guidanceScale;
            this.OutputFormat = outputFormat;
            this.EnableSyncMode = enableSyncMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoGenerationRequest" /> class.
        /// </summary>
        public VideoGenerationRequest()
        {
        }
    }
}