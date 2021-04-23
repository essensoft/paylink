using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceIotServiceutilBuildtextSendResponse.
    /// </summary>
    public class AlipayCommerceIotServiceutilBuildtextSendResponse : AlipayResponse
    {
        /// <summary>
        /// 语音文件id
        /// </summary>
        [JsonPropertyName("audio_id")]
        public string AudioId { get; set; }

        /// <summary>
        /// 文件md5
        /// </summary>
        [JsonPropertyName("md_5")]
        public string Md5 { get; set; }

        /// <summary>
        /// 语音文件url
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
