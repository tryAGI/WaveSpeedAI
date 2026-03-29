
#nullable enable

namespace WaveSpeedAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TaskUrls
    {
        /// <summary>
        /// URL to retrieve the task result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("get")]
        public string? Get { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskUrls" /> class.
        /// </summary>
        /// <param name="get">
        /// URL to retrieve the task result.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TaskUrls(
            string? get)
        {
            this.Get = get;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskUrls" /> class.
        /// </summary>
        public TaskUrls()
        {
        }
    }
}