
#nullable enable

namespace WaveSpeedAI
{
    /// <summary>
    /// WaveSpeed AI is a multi-model generation platform providing unified API access to 700+ AI models<br/>
    /// for image generation, video generation, and audio generation. The API follows an async task pattern:<br/>
    /// submit a generation request, then poll for the result.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IWaveSpeedAIClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::WaveSpeedAI.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }
        /// <summary>
        /// Client-wide request defaults such as headers, query parameters, retries, and timeout.
        /// </summary>
        public global::WaveSpeedAI.AutoSDKClientOptions Options { get; }


        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public ImageGenerationClient ImageGeneration { get; }

        /// <summary>
        /// 
        /// </summary>
        public MediaClient Media { get; }

        /// <summary>
        /// 
        /// </summary>
        public PredictionsClient Predictions { get; }

        /// <summary>
        /// 
        /// </summary>
        public VideoGenerationClient VideoGeneration { get; }

    }
}