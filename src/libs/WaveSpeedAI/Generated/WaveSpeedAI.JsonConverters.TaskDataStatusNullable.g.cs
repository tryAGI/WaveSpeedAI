#nullable enable

namespace WaveSpeedAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class TaskDataStatusNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::WaveSpeedAI.TaskDataStatus?>
    {
        /// <inheritdoc />
        public override global::WaveSpeedAI.TaskDataStatus? Read(
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
                        return global::WaveSpeedAI.TaskDataStatusExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::WaveSpeedAI.TaskDataStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::WaveSpeedAI.TaskDataStatus?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::WaveSpeedAI.TaskDataStatus? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::WaveSpeedAI.TaskDataStatusExtensions.ToValueString(value.Value));
            }
        }
    }
}
