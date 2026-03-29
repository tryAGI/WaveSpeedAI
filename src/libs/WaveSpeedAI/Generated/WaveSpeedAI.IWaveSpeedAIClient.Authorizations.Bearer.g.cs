
#nullable enable

namespace WaveSpeedAI
{
    public partial interface IWaveSpeedAIClient
    {
        /// <summary>
        /// Authorize using bearer authentication.
        /// </summary>
        /// <param name="apiKey"></param>
        public void AuthorizeUsingBearer(
            string apiKey);
    }
}