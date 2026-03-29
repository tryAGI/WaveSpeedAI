
#nullable enable

namespace WaveSpeedAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TaskData
    {
        /// <summary>
        /// Unique task/prediction identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Model identifier used for generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Array of output URLs (images, videos, audio). Populated when status is completed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputs")]
        public global::System.Collections.Generic.IList<string>? Outputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("urls")]
        public global::WaveSpeedAI.TaskUrls? Urls { get; set; }

        /// <summary>
        /// NSFW detection flags per output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_nsfw_contents")]
        public global::System.Collections.Generic.IList<bool>? HasNsfwContents { get; set; }

        /// <summary>
        /// Current task status.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::WaveSpeedAI.JsonConverters.TaskDataStatusJsonConverter))]
        public global::WaveSpeedAI.TaskDataStatus? Status { get; set; }

        /// <summary>
        /// ISO 8601 timestamp when the task was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Error message if the task failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

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
        /// Initializes a new instance of the <see cref="TaskData" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique task/prediction identifier.
        /// </param>
        /// <param name="model">
        /// Model identifier used for generation.
        /// </param>
        /// <param name="outputs">
        /// Array of output URLs (images, videos, audio). Populated when status is completed.
        /// </param>
        /// <param name="urls"></param>
        /// <param name="hasNsfwContents">
        /// NSFW detection flags per output.
        /// </param>
        /// <param name="status">
        /// Current task status.
        /// </param>
        /// <param name="createdAt">
        /// ISO 8601 timestamp when the task was created.
        /// </param>
        /// <param name="error">
        /// Error message if the task failed.
        /// </param>
        /// <param name="timings"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TaskData(
            string? id,
            string? model,
            global::System.Collections.Generic.IList<string>? outputs,
            global::WaveSpeedAI.TaskUrls? urls,
            global::System.Collections.Generic.IList<bool>? hasNsfwContents,
            global::WaveSpeedAI.TaskDataStatus? status,
            global::System.DateTime? createdAt,
            string? error,
            global::WaveSpeedAI.TaskTimings? timings)
        {
            this.Id = id;
            this.Model = model;
            this.Outputs = outputs;
            this.Urls = urls;
            this.HasNsfwContents = hasNsfwContents;
            this.Status = status;
            this.CreatedAt = createdAt;
            this.Error = error;
            this.Timings = timings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskData" /> class.
        /// </summary>
        public TaskData()
        {
        }
    }
}