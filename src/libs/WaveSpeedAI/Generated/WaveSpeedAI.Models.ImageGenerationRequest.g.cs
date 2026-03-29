
#nullable enable

namespace WaveSpeedAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageGenerationRequest
    {
        /// <summary>
        /// Text description of the image to generate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Source image URL for image-to-image or inpainting mode.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public string? Image { get; set; }

        /// <summary>
        /// Mask image URL. White areas will be regenerated, black areas preserved.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mask_image")]
        public string? MaskImage { get; set; }

        /// <summary>
        /// Extent to transform the reference image. Range 0.0 to 1.0.<br/>
        /// Default Value: 0.8
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strength")]
        public double? Strength { get; set; }

        /// <summary>
        /// Output dimensions in pixels (width*height format). Each dimension 256-1536.<br/>
        /// Default Value: 1024*1024
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public string? Size { get; set; }

        /// <summary>
        /// Number of inference iterations. Range 1-50.<br/>
        /// Default Value: 28
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_inference_steps")]
        public int? NumInferenceSteps { get; set; }

        /// <summary>
        /// Random seed. Use -1 for random generation. Range -1 to 2147483647.<br/>
        /// Default Value: -1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Prompt adherence strength. Range 1.0 to 20.0.<br/>
        /// Default Value: 3.5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guidance_scale")]
        public double? GuidanceScale { get; set; }

        /// <summary>
        /// Number of images to generate. Range 1-4.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_images")]
        public int? NumImages { get; set; }

        /// <summary>
        /// Output image file format.<br/>
        /// Default Value: jpeg
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::WaveSpeedAI.JsonConverters.ImageGenerationRequestOutputFormatJsonConverter))]
        public global::WaveSpeedAI.ImageGenerationRequestOutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// Array of LoRA configurations to apply.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("loras")]
        public global::System.Collections.Generic.IList<global::WaveSpeedAI.LoraConfig>? Loras { get; set; }

        /// <summary>
        /// Return BASE64 encoded output instead of URL.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_base64_output")]
        public bool? EnableBase64Output { get; set; }

        /// <summary>
        /// Wait for result before returning the response (synchronous mode).<br/>
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
        /// Initializes a new instance of the <see cref="ImageGenerationRequest" /> class.
        /// </summary>
        /// <param name="prompt">
        /// Text description of the image to generate.
        /// </param>
        /// <param name="image">
        /// Source image URL for image-to-image or inpainting mode.
        /// </param>
        /// <param name="maskImage">
        /// Mask image URL. White areas will be regenerated, black areas preserved.
        /// </param>
        /// <param name="strength">
        /// Extent to transform the reference image. Range 0.0 to 1.0.<br/>
        /// Default Value: 0.8
        /// </param>
        /// <param name="size">
        /// Output dimensions in pixels (width*height format). Each dimension 256-1536.<br/>
        /// Default Value: 1024*1024
        /// </param>
        /// <param name="numInferenceSteps">
        /// Number of inference iterations. Range 1-50.<br/>
        /// Default Value: 28
        /// </param>
        /// <param name="seed">
        /// Random seed. Use -1 for random generation. Range -1 to 2147483647.<br/>
        /// Default Value: -1
        /// </param>
        /// <param name="guidanceScale">
        /// Prompt adherence strength. Range 1.0 to 20.0.<br/>
        /// Default Value: 3.5
        /// </param>
        /// <param name="numImages">
        /// Number of images to generate. Range 1-4.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="outputFormat">
        /// Output image file format.<br/>
        /// Default Value: jpeg
        /// </param>
        /// <param name="loras">
        /// Array of LoRA configurations to apply.
        /// </param>
        /// <param name="enableBase64Output">
        /// Return BASE64 encoded output instead of URL.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="enableSyncMode">
        /// Wait for result before returning the response (synchronous mode).<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageGenerationRequest(
            string prompt,
            string? image,
            string? maskImage,
            double? strength,
            string? size,
            int? numInferenceSteps,
            int? seed,
            double? guidanceScale,
            int? numImages,
            global::WaveSpeedAI.ImageGenerationRequestOutputFormat? outputFormat,
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
        /// Initializes a new instance of the <see cref="ImageGenerationRequest" /> class.
        /// </summary>
        public ImageGenerationRequest()
        {
        }
    }
}