#nullable enable

namespace WaveSpeedAI
{
    public partial interface IVideoGenerationClient
    {
        /// <summary>
        /// Generate video with Wan 2.1 Text-to-Video (720p)<br/>
        /// Generates a 720p video from a text prompt using the Wan 2.1 model.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::WaveSpeedAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::WaveSpeedAI.TaskResponse> GenerateWanTextToVideo720pAsync(

            global::WaveSpeedAI.VideoGenerationRequest request,
            global::WaveSpeedAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate video with Wan 2.1 Text-to-Video (720p)<br/>
        /// Generates a 720p video from a text prompt using the Wan 2.1 model.
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::WaveSpeedAI.TaskResponse> GenerateWanTextToVideo720pAsync(
            string prompt,
            string? image = default,
            string? size = default,
            int? numInferenceSteps = default,
            int? seed = default,
            double? guidanceScale = default,
            global::WaveSpeedAI.VideoGenerationRequestOutputFormat? outputFormat = default,
            bool? enableSyncMode = default,
            global::WaveSpeedAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}