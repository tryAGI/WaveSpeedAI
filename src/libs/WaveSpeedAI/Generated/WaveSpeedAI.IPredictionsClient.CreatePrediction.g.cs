#nullable enable

namespace WaveSpeedAI
{
    public partial interface IPredictionsClient
    {
        /// <summary>
        /// Create a prediction with any model<br/>
        /// Submits a generation task to any model on the WaveSpeed AI platform. The modelId follows<br/>
        /// the format {provider}/{model-name}, e.g., "wavespeed-ai/flux-dev", "google/imagen-4",<br/>
        /// "bytedance/seedance-1.0-lite". Returns a task object with an ID for polling.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="webhook"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::WaveSpeedAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::WaveSpeedAI.TaskResponse> CreatePredictionAsync(
            string modelId,

            global::WaveSpeedAI.CreatePredictionRequest request,
            string? webhook = default,
            global::WaveSpeedAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a prediction with any model<br/>
        /// Submits a generation task to any model on the WaveSpeed AI platform. The modelId follows<br/>
        /// the format {provider}/{model-name}, e.g., "wavespeed-ai/flux-dev", "google/imagen-4",<br/>
        /// "bytedance/seedance-1.0-lite". Returns a task object with an ID for polling.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="webhook"></param>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::WaveSpeedAI.TaskResponse> CreatePredictionAsync(
            string modelId,
            string prompt,
            string? webhook = default,
            string? image = default,
            string? maskImage = default,
            double? strength = default,
            string? size = default,
            int? numInferenceSteps = default,
            int? seed = default,
            double? guidanceScale = default,
            int? numImages = default,
            string? outputFormat = default,
            global::System.Collections.Generic.IList<global::WaveSpeedAI.LoraConfig>? loras = default,
            bool? enableBase64Output = default,
            bool? enableSyncMode = default,
            global::WaveSpeedAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}