
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace WaveSpeedAI
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::WaveSpeedAI.JsonConverters.TaskDataStatusJsonConverter),

            typeof(global::WaveSpeedAI.JsonConverters.TaskDataStatusNullableJsonConverter),

            typeof(global::WaveSpeedAI.JsonConverters.PredictionItemStatusJsonConverter),

            typeof(global::WaveSpeedAI.JsonConverters.PredictionItemStatusNullableJsonConverter),

            typeof(global::WaveSpeedAI.JsonConverters.ImageGenerationRequestOutputFormatJsonConverter),

            typeof(global::WaveSpeedAI.JsonConverters.ImageGenerationRequestOutputFormatNullableJsonConverter),

            typeof(global::WaveSpeedAI.JsonConverters.VideoGenerationRequestOutputFormatJsonConverter),

            typeof(global::WaveSpeedAI.JsonConverters.VideoGenerationRequestOutputFormatNullableJsonConverter),

            typeof(global::WaveSpeedAI.JsonConverters.UploadDataTypeJsonConverter),

            typeof(global::WaveSpeedAI.JsonConverters.UploadDataTypeNullableJsonConverter),

            typeof(global::WaveSpeedAI.JsonConverters.ListPredictionsRequestStatusJsonConverter),

            typeof(global::WaveSpeedAI.JsonConverters.ListPredictionsRequestStatusNullableJsonConverter),

            typeof(global::WaveSpeedAI.JsonConverters.TaskResponseJsonConverter),

            typeof(global::WaveSpeedAI.JsonConverters.PredictionListResponseJsonConverter),

            typeof(global::WaveSpeedAI.JsonConverters.UploadResponseJsonConverter),

            typeof(global::WaveSpeedAI.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WaveSpeedAI.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WaveSpeedAI.ApiResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WaveSpeedAI.TaskUrls))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WaveSpeedAI.TaskTimings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WaveSpeedAI.TaskData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<bool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WaveSpeedAI.TaskDataStatus), TypeInfoPropertyName = "TaskDataStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WaveSpeedAI.TaskResponse), TypeInfoPropertyName = "TaskResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WaveSpeedAI.TaskResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WaveSpeedAI.PredictionItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WaveSpeedAI.PredictionItemStatus), TypeInfoPropertyName = "PredictionItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WaveSpeedAI.PredictionListData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::WaveSpeedAI.PredictionItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WaveSpeedAI.PredictionListResponse), TypeInfoPropertyName = "PredictionListResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WaveSpeedAI.PredictionListResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WaveSpeedAI.LoraConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WaveSpeedAI.ImageGenerationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WaveSpeedAI.ImageGenerationRequestOutputFormat), TypeInfoPropertyName = "ImageGenerationRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::WaveSpeedAI.LoraConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WaveSpeedAI.VideoGenerationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WaveSpeedAI.VideoGenerationRequestOutputFormat), TypeInfoPropertyName = "VideoGenerationRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WaveSpeedAI.UploadData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WaveSpeedAI.UploadDataType), TypeInfoPropertyName = "UploadDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WaveSpeedAI.UploadResponse), TypeInfoPropertyName = "UploadResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WaveSpeedAI.UploadResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WaveSpeedAI.CreatePredictionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WaveSpeedAI.ListPredictionsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WaveSpeedAI.ListPredictionsRequestStatus), TypeInfoPropertyName = "ListPredictionsRequestStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::WaveSpeedAI.UploadMediaRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<bool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::WaveSpeedAI.PredictionItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::WaveSpeedAI.LoraConfig>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}