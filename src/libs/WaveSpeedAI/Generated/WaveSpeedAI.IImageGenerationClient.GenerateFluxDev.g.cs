#nullable enable

namespace WaveSpeedAI
{
    public partial interface IImageGenerationClient
    {
        /// <summary>
        /// Generate image with FLUX Dev<br/>
        /// Generates an image using the WaveSpeed AI FLUX Dev model. FLUX Dev is a versatile image generation model supporting text-to-image, image-to-image, and inpainting.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::WaveSpeedAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::WaveSpeedAI.TaskResponse> GenerateFluxDevAsync(

            global::WaveSpeedAI.ImageGenerationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate image with FLUX Dev<br/>
        /// Generates an image using the WaveSpeed AI FLUX Dev model. FLUX Dev is a versatile image generation model supporting text-to-image, image-to-image, and inpainting.
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::WaveSpeedAI.TaskResponse> GenerateFluxDevAsync(
            string prompt,
            string? image = default,
            string? maskImage = default,
            double? strength = default,
            string? size = default,
            int? numInferenceSteps = default,
            int? seed = default,
            double? guidanceScale = default,
            int? numImages = default,
            global::WaveSpeedAI.ImageGenerationRequestOutputFormat? outputFormat = default,
            global::System.Collections.Generic.IList<global::WaveSpeedAI.LoraConfig>? loras = default,
            bool? enableBase64Output = default,
            bool? enableSyncMode = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}