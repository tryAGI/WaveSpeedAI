#nullable enable

namespace WaveSpeedAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class ImageGenerationRequestOutputFormatJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::WaveSpeedAI.ImageGenerationRequestOutputFormat>
    {
        /// <inheritdoc />
        public override global::WaveSpeedAI.ImageGenerationRequestOutputFormat Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::WaveSpeedAI.ImageGenerationRequestOutputFormatExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::WaveSpeedAI.ImageGenerationRequestOutputFormat)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::WaveSpeedAI.ImageGenerationRequestOutputFormat);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::WaveSpeedAI.ImageGenerationRequestOutputFormat value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::WaveSpeedAI.ImageGenerationRequestOutputFormatExtensions.ToValueString(value));
        }
    }
}
