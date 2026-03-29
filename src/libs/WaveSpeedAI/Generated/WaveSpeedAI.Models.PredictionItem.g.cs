
#nullable enable

namespace WaveSpeedAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PredictionItem
    {
        /// <summary>
        /// Unique prediction identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Model identifier used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Array of output URLs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputs")]
        public global::System.Collections.Generic.IList<string>? Outputs { get; set; }

        /// <summary>
        /// Prediction status.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::WaveSpeedAI.JsonConverters.PredictionItemStatusJsonConverter))]
        public global::WaveSpeedAI.PredictionItemStatus? Status { get; set; }

        /// <summary>
        /// ISO 8601 timestamp when created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Total execution time in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("executionTime")]
        public double? ExecutionTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timings")]
        public global::WaveSpeedAI.TaskTimings? Timings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PredictionItem" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique prediction identifier.
        /// </param>
        /// <param name="model">
        /// Model identifier used.
        /// </param>
        /// <param name="outputs">
        /// Array of output URLs.
        /// </param>
        /// <param name="status">
        /// Prediction status.
        /// </param>
        /// <param name="createdAt">
        /// ISO 8601 timestamp when created.
        /// </param>
        /// <param name="executionTime">
        /// Total execution time in milliseconds.
        /// </param>
        /// <param name="timings"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PredictionItem(
            string? id,
            string? model,
            global::System.Collections.Generic.IList<string>? outputs,
            global::WaveSpeedAI.PredictionItemStatus? status,
            global::System.DateTime? createdAt,
            double? executionTime,
            global::WaveSpeedAI.TaskTimings? timings)
        {
            this.Id = id;
            this.Model = model;
            this.Outputs = outputs;
            this.Status = status;
            this.CreatedAt = createdAt;
            this.ExecutionTime = executionTime;
            this.Timings = timings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PredictionItem" /> class.
        /// </summary>
        public PredictionItem()
        {
        }
    }
}