
#nullable enable

namespace WaveSpeedAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListPredictionsRequest
    {
        /// <summary>
        /// Page number for pagination (starting at 1).<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Page { get; set; }

        /// <summary>
        /// Number of records per page (1-100).<br/>
        /// Default Value: 100
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PageSize { get; set; }

        /// <summary>
        /// Filter by model identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Filter by task status.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::WaveSpeedAI.JsonConverters.ListPredictionsRequestStatusJsonConverter))]
        public global::WaveSpeedAI.ListPredictionsRequestStatus? Status { get; set; }

        /// <summary>
        /// ISO 8601 datetime to filter predictions created after this time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_after")]
        public global::System.DateTime? CreatedAfter { get; set; }

        /// <summary>
        /// ISO 8601 datetime to filter predictions created before this time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_before")]
        public global::System.DateTime? CreatedBefore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListPredictionsRequest" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListPredictionsRequest(
            int page,
            int pageSize,
            string? model,
            global::WaveSpeedAI.ListPredictionsRequestStatus? status,
            global::System.DateTime? createdAfter,
            global::System.DateTime? createdBefore)
        {
            this.Page = page;
            this.PageSize = pageSize;
            this.Model = model;
            this.Status = status;
            this.CreatedAfter = createdAfter;
            this.CreatedBefore = createdBefore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListPredictionsRequest" /> class.
        /// </summary>
        public ListPredictionsRequest()
        {
        }
    }
}