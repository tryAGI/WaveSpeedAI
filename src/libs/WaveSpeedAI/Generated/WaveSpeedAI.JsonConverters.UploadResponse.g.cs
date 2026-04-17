#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace WaveSpeedAI.JsonConverters
{
    /// <inheritdoc />
    public class UploadResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::WaveSpeedAI.UploadResponse>
    {
        /// <inheritdoc />
        public override global::WaveSpeedAI.UploadResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                    if (__jsonProp.Value.ValueKind == global::System.Text.Json.JsonValueKind.Object)
                    {
                        foreach (var __nestedJsonProp in __jsonProp.Value.EnumerateObject())
                        {
                            __jsonProps.Add(__jsonProp.Name + "." + __nestedJsonProp.Name);
                        }
                    }

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("code")) __score0++;
            if (__jsonProps.Contains("message")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("data")) __score1++;
            if (__jsonProps.Contains("data.download_url")) __score1++;
            if (__jsonProps.Contains("data.filename")) __score1++;
            if (__jsonProps.Contains("data.size")) __score1++;
            if (__jsonProps.Contains("data.type")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::WaveSpeedAI.ApiResponse? api = default;
            global::WaveSpeedAI.UploadResponseVariant2? uploadResponseVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::WaveSpeedAI.ApiResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::WaveSpeedAI.ApiResponse> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::WaveSpeedAI.ApiResponse).Name}");
                        api = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::WaveSpeedAI.UploadResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::WaveSpeedAI.UploadResponseVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::WaveSpeedAI.UploadResponseVariant2).Name}");
                        uploadResponseVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (api == null && uploadResponseVariant2 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::WaveSpeedAI.ApiResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::WaveSpeedAI.ApiResponse> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::WaveSpeedAI.ApiResponse).Name}");
                    api = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::WaveSpeedAI.UploadResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::WaveSpeedAI.UploadResponseVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::WaveSpeedAI.UploadResponseVariant2).Name}");
                    uploadResponseVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::WaveSpeedAI.UploadResponse(
                api,

                uploadResponseVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::WaveSpeedAI.UploadResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsApi)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::WaveSpeedAI.ApiResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::WaveSpeedAI.ApiResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::WaveSpeedAI.ApiResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Api!, typeInfo);
            }
            else if (value.IsUploadResponseVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::WaveSpeedAI.UploadResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::WaveSpeedAI.UploadResponseVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::WaveSpeedAI.UploadResponseVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UploadResponseVariant2!, typeInfo);
            }
        }
    }
}