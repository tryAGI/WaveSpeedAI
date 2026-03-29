#nullable enable

namespace WaveSpeedAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class VideoGenerationRequestOutputFormatNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::WaveSpeedAI.VideoGenerationRequestOutputFormat?>
    {
        /// <inheritdoc />
        public override global::WaveSpeedAI.VideoGenerationRequestOutputFormat? Read(
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
                        return global::WaveSpeedAI.VideoGenerationRequestOutputFormatExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::WaveSpeedAI.VideoGenerationRequestOutputFormat)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::WaveSpeedAI.VideoGenerationRequestOutputFormat?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::WaveSpeedAI.VideoGenerationRequestOutputFormat? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::WaveSpeedAI.VideoGenerationRequestOutputFormatExtensions.ToValueString(value.Value));
            }
        }
    }
}
