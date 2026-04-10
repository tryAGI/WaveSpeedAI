#nullable enable

namespace WaveSpeedAI
{
    public partial interface IPredictionsClient
    {
        /// <summary>
        /// Get task result<br/>
        /// Retrieves the current status and result of a generation task by its ID.<br/>
        /// Poll this endpoint until status is "completed" or "failed".
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::WaveSpeedAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::WaveSpeedAI.TaskResponse> GetTaskResultAsync(
            string taskId,
            global::WaveSpeedAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}