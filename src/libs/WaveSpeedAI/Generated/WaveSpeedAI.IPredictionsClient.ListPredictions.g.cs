#nullable enable

namespace WaveSpeedAI
{
    public partial interface IPredictionsClient
    {
        /// <summary>
        /// List prediction history<br/>
        /// Retrieves a paginated list of your prediction history. Includes predictions from both<br/>
        /// API and web interface. Only data from the past 7 days is available, with a maximum<br/>
        /// of 100 records per page.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::WaveSpeedAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::WaveSpeedAI.PredictionListResponse> ListPredictionsAsync(

            global::WaveSpeedAI.ListPredictionsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List prediction history<br/>
        /// Retrieves a paginated list of your prediction history. Includes predictions from both<br/>
        /// API and web interface. Only data from the past 7 days is available, with a maximum<br/>
        /// of 100 records per page.
        /// </summary>
        /// <param name="page">
        /// Page number for pagination (starting at 1).<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Number of records per page (1-100).<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="model">
        /// Filter by model identifier.
        /// </param>
        /// <param name="status">
        /// Filter by task status.
        /// </param>
        /// <param name="createdAfter">
        /// ISO 8601 datetime to filter predictions created after this time.
        /// </param>
        /// <param name="createdBefore">
        /// ISO 8601 datetime to filter predictions created before this time.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::WaveSpeedAI.PredictionListResponse> ListPredictionsAsync(
            int page,
            int pageSize,
            string? model = default,
            global::WaveSpeedAI.ListPredictionsRequestStatus? status = default,
            global::System.DateTime? createdAfter = default,
            global::System.DateTime? createdBefore = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}