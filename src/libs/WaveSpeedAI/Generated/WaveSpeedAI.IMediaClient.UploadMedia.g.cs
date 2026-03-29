#nullable enable

namespace WaveSpeedAI
{
    public partial interface IMediaClient
    {
        /// <summary>
        /// Upload a media file<br/>
        /// Uploads an image, video, or audio file to WaveSpeed AI servers. The returned download_url<br/>
        /// can be used as input for generation models that accept media URLs. Supported formats include<br/>
        /// JPG, PNG, WebP, GIF, MP4, MOV, MP3, WAV, and more. Files are stored for 7 days.<br/>
        /// Files exceeding 300MB should be provided via URL instead.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::WaveSpeedAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::WaveSpeedAI.UploadResponse> UploadMediaAsync(

            global::WaveSpeedAI.UploadMediaRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload a media file<br/>
        /// Uploads an image, video, or audio file to WaveSpeed AI servers. The returned download_url<br/>
        /// can be used as input for generation models that accept media URLs. Supported formats include<br/>
        /// JPG, PNG, WebP, GIF, MP4, MOV, MP3, WAV, and more. Files are stored for 7 days.<br/>
        /// Files exceeding 300MB should be provided via URL instead.
        /// </summary>
        /// <param name="file">
        /// The media file to upload (image, video, or audio).
        /// </param>
        /// <param name="filename">
        /// The media file to upload (image, video, or audio).
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::WaveSpeedAI.UploadResponse> UploadMediaAsync(
            byte[] file,
            string filename,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}