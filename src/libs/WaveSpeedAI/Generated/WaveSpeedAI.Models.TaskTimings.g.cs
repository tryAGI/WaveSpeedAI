
#nullable enable

namespace WaveSpeedAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TaskTimings
    {
        /// <summary>
        /// Inference processing time in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inference")]
        public double? Inference { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskTimings" /> class.
        /// </summary>
        /// <param name="inference">
        /// Inference processing time in milliseconds.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TaskTimings(
            double? inference)
        {
            this.Inference = inference;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskTimings" /> class.
        /// </summary>
        public TaskTimings()
        {
        }
    }
}