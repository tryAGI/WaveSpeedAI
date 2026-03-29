#nullable enable

namespace WaveSpeedAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class ListPredictionsRequestStatusJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::WaveSpeedAI.ListPredictionsRequestStatus>
    {
        /// <inheritdoc />
        public override global::WaveSpeedAI.ListPredictionsRequestStatus Read(
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
                        return global::WaveSpeedAI.ListPredictionsRequestStatusExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::WaveSpeedAI.ListPredictionsRequestStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::WaveSpeedAI.ListPredictionsRequestStatus);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::WaveSpeedAI.ListPredictionsRequestStatus value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::WaveSpeedAI.ListPredictionsRequestStatusExtensions.ToValueString(value));
        }
    }
}
