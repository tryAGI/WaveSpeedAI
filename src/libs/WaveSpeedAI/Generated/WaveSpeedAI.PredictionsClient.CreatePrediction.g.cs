
#nullable enable

namespace WaveSpeedAI
{
    public partial class PredictionsClient
    {
        partial void PrepareCreatePredictionArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string modelId,
            ref string? webhook,
            global::WaveSpeedAI.CreatePredictionRequest request);
        partial void PrepareCreatePredictionRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string modelId,
            string? webhook,
            global::WaveSpeedAI.CreatePredictionRequest request);
        partial void ProcessCreatePredictionResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreatePredictionResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create a prediction with any model<br/>
        /// Submits a generation task to any model on the WaveSpeed AI platform. The modelId follows<br/>
        /// the format {provider}/{model-name}, e.g., "wavespeed-ai/flux-dev", "google/imagen-4",<br/>
        /// "bytedance/seedance-1.0-lite". Returns a task object with an ID for polling.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="webhook"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::WaveSpeedAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::WaveSpeedAI.TaskResponse> CreatePredictionAsync(
            string modelId,

            global::WaveSpeedAI.CreatePredictionRequest request,
            string? webhook = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreatePredictionArguments(
                httpClient: HttpClient,
                modelId: ref modelId,
                webhook: ref webhook,
                request: request);

            var __pathBuilder = new global::WaveSpeedAI.PathBuilder(
                path: $"/{modelId}",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("webhook", webhook) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreatePredictionRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                modelId: modelId,
                webhook: webhook,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreatePredictionResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // 
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::WaveSpeedAI.ApiException(
                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_400,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_400,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // 
            if ((int)__response.StatusCode == 401)
            {
                string? __content_401 = null;
                global::System.Exception? __exception_401 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_401 = __ex;
                }

                throw new global::WaveSpeedAI.ApiException(
                    message: __content_401 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_401,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_401,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // 
            if ((int)__response.StatusCode == 429)
            {
                string? __content_429 = null;
                global::System.Exception? __exception_429 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_429 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_429 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_429 = __ex;
                }

                throw new global::WaveSpeedAI.ApiException(
                    message: __content_429 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_429,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_429,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessCreatePredictionResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::WaveSpeedAI.TaskResponse.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::WaveSpeedAI.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::WaveSpeedAI.TaskResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::WaveSpeedAI.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
        /// <summary>
        /// Create a prediction with any model<br/>
        /// Submits a generation task to any model on the WaveSpeed AI platform. The modelId follows<br/>
        /// the format {provider}/{model-name}, e.g., "wavespeed-ai/flux-dev", "google/imagen-4",<br/>
        /// "bytedance/seedance-1.0-lite". Returns a task object with an ID for polling.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="webhook"></param>
        /// <param name="prompt">
        /// Text prompt describing the desired output.
        /// </param>
        /// <param name="image">
        /// Source image URL for image-to-image, image-to-video, or inpainting.
        /// </param>
        /// <param name="maskImage">
        /// Mask image URL for inpainting (white=regenerate, black=preserve).
        /// </param>
        /// <param name="strength">
        /// Transformation strength for image-to-image. Range 0.0 to 1.0.
        /// </param>
        /// <param name="size">
        /// Output dimensions in width*height format.
        /// </param>
        /// <param name="numInferenceSteps">
        /// Number of inference iterations.
        /// </param>
        /// <param name="seed">
        /// Random seed (-1 for random).
        /// </param>
        /// <param name="guidanceScale">
        /// Prompt adherence strength.
        /// </param>
        /// <param name="numImages">
        /// Number of outputs to generate.
        /// </param>
        /// <param name="outputFormat">
        /// Output file format (jpeg, png, webp, mp4, gif).
        /// </param>
        /// <param name="loras">
        /// LoRA configurations to apply.
        /// </param>
        /// <param name="enableBase64Output">
        /// Return BASE64 encoded output.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="enableSyncMode">
        /// Wait for completion before returning.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::WaveSpeedAI.TaskResponse> CreatePredictionAsync(
            string modelId,
            string prompt,
            string? webhook = default,
            string? image = default,
            string? maskImage = default,
            double? strength = default,
            string? size = default,
            int? numInferenceSteps = default,
            int? seed = default,
            double? guidanceScale = default,
            int? numImages = default,
            string? outputFormat = default,
            global::System.Collections.Generic.IList<global::WaveSpeedAI.LoraConfig>? loras = default,
            bool? enableBase64Output = default,
            bool? enableSyncMode = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::WaveSpeedAI.CreatePredictionRequest
            {
                Prompt = prompt,
                Image = image,
                MaskImage = maskImage,
                Strength = strength,
                Size = size,
                NumInferenceSteps = numInferenceSteps,
                Seed = seed,
                GuidanceScale = guidanceScale,
                NumImages = numImages,
                OutputFormat = outputFormat,
                Loras = loras,
                EnableBase64Output = enableBase64Output,
                EnableSyncMode = enableSyncMode,
            };

            return await CreatePredictionAsync(
                modelId: modelId,
                webhook: webhook,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}