
#nullable enable

namespace WaveSpeedAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PredictionListData
    {
        /// <summary>
        /// Current page number.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page")]
        public int? Page { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        public global::System.Collections.Generic.IList<global::WaveSpeedAI.PredictionItem>? Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PredictionListData" /> class.
        /// </summary>
        /// <param name="page">
        /// Current page number.
        /// </param>
        /// <param name="items"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PredictionListData(
            int? page,
            global::System.Collections.Generic.IList<global::WaveSpeedAI.PredictionItem>? items)
        {
            this.Page = page;
            this.Items = items;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PredictionListData" /> class.
        /// </summary>
        public PredictionListData()
        {
        }
    }
}