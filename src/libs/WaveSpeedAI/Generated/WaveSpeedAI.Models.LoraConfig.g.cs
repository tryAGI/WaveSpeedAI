
#nullable enable

namespace WaveSpeedAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LoraConfig
    {
        /// <summary>
        /// URL or path to the LoRA weights file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// Scale factor for LoRA influence. Range 0.0 to 1.0.<br/>
        /// Default Value: 1.0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scale")]
        public double? Scale { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LoraConfig" /> class.
        /// </summary>
        /// <param name="path">
        /// URL or path to the LoRA weights file.
        /// </param>
        /// <param name="scale">
        /// Scale factor for LoRA influence. Range 0.0 to 1.0.<br/>
        /// Default Value: 1.0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LoraConfig(
            string? path,
            double? scale)
        {
            this.Path = path;
            this.Scale = scale;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoraConfig" /> class.
        /// </summary>
        public LoraConfig()
        {
        }
    }
}