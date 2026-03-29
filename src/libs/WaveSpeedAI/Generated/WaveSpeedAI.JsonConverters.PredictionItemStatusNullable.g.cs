#nullable enable

namespace WaveSpeedAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class PredictionItemStatusNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::WaveSpeedAI.PredictionItemStatus?>
    {
        /// <inheritdoc />
        public override global::WaveSpeedAI.PredictionItemStatus? Read(
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
                        return global::WaveSpeedAI.PredictionItemStatusExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::WaveSpeedAI.PredictionItemStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::WaveSpeedAI.PredictionItemStatus?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::WaveSpeedAI.PredictionItemStatus? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::WaveSpeedAI.PredictionItemStatusExtensions.ToValueString(value.Value));
            }
        }
    }
}
