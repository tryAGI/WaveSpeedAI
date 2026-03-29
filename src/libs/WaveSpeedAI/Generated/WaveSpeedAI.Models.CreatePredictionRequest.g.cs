
#nullable enable

namespace WaveSpeedAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreatePredictionRequest
    {
        /// <summary>
        /// Text prompt describing the desired output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Source image URL for image-to-image, image-to-video, or inpainting.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public string? Image { get; set; }

        /// <summary>
        /// Mask image URL for inpainting (white=regenerate, black=preserve).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mask_image")]
        public string? MaskImage { get; set; }

        /// <summary>
        /// Transformation strength for image-to-image. Range 0.0 to 1.0.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strength")]
        public double? Strength { get; set; }

        /// <summary>
        /// Output dimensions in width*height format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public string? Size { get; set; }

        /// <summary>
        /// Number of inference iterations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_inference_steps")]
        public int? NumInferenceSteps { get; set; }

        /// <summary>
        /// Random seed (-1 for random).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Prompt adherence strength.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guidance_scale")]
        public double? GuidanceScale { get; set; }

        /// <summary>
        /// Number of outputs to generate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_images")]
        public int? NumImages { get; set; }

        /// <summary>
        /// Output file format (jpeg, png, webp, mp4, gif).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        public string? OutputFormat { get; set; }

        /// <summary>
        /// LoRA configurations to apply.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("loras")]
        public global::System.Collections.Generic.IList<global::WaveSpeedAI.LoraConfig>? Loras { get; set; }

        /// <summary>
        /// Return BASE64 encoded output.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_base64_output")]
        public bool? EnableBase64Output { get; set; }

        /// <summary>
        /// Wait for completion before returning.<br/>
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
        /// Initializes a new instance of the <see cref="CreatePredictionRequest" /> class.
        /// </summary>
        /// <param name="prompt">
        /// Text prompt describing the desired output.
        /// </param>
        /// <param name="image">
        /// Source image URL for image-to-image, image-to-video, or inpainting.
        /// </param>
        /// <param name="maskImage">
        /// Mask image URL for inpainting (white=regenerate, black=preserve).
        /// </param>
        /// <param name="strength">
        /// Transformation strength for image-to-image. Range 0.0 to 1.0.
        /// </param>
        /// <param name="size">
        /// Output dimensions in width*height format.
        /// </param>
        /// <param name="numInferenceSteps">
        /// Number of inference iterations.
        /// </param>
        /// <param name="seed">
        /// Random seed (-1 for random).
        /// </param>
        /// <param name="guidanceScale">
        /// Prompt adherence strength.
        /// </param>
        /// <param name="numImages">
        /// Number of outputs to generate.
        /// </param>
        /// <param name="outputFormat">
        /// Output file format (jpeg, png, webp, mp4, gif).
        /// </param>
        /// <param name="loras">
        /// LoRA configurations to apply.
        /// </param>
        /// <param name="enableBase64Output">
        /// Return BASE64 encoded output.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="enableSyncMode">
        /// Wait for completion before returning.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreatePredictionRequest(
            string prompt,
            string? image,
            string? maskImage,
            double? strength,
            string? size,
            int? numInferenceSteps,
            int? seed,
            double? guidanceScale,
            int? numImages,
            string? outputFormat,
            global::System.Collections.Generic.IList<global::WaveSpeedAI.LoraConfig>? loras,
            bool? enableBase64Output,
            bool? enableSyncMode)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Image = image;
            this.MaskImage = maskImage;
            this.Strength = strength;
            this.Size = size;
            this.NumInferenceSteps = numInferenceSteps;
            this.Seed = seed;
            this.GuidanceScale = guidanceScale;
            this.NumImages = numImages;
            this.OutputFormat = outputFormat;
            this.Loras = loras;
            this.EnableBase64Output = enableBase64Output;
            this.EnableSyncMode = enableSyncMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePredictionRequest" /> class.
        /// </summary>
        public CreatePredictionRequest()
        {
        }
    }
}