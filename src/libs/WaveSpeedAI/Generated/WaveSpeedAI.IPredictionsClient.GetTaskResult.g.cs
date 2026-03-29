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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::WaveSpeedAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::WaveSpeedAI.TaskResponse> GetTaskResultAsync(
            string taskId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}