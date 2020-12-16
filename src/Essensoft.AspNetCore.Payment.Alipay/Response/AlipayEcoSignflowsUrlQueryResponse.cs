using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcoSignflowsUrlQueryResponse.
    /// </summary>
    public class AlipayEcoSignflowsUrlQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 预览短链地址（30天有效）
        /// </summary>
        [JsonPropertyName("preview_short_url")]
        public string PreviewShortUrl { get; set; }

        /// <summary>
        /// 预览长链地址(永久有效)
        /// </summary>
        [JsonPropertyName("preview_url")]
        public string PreviewUrl { get; set; }

        /// <summary>
        /// 签署短链地址（30天有效）
        /// </summary>
        [JsonPropertyName("sign_short_url")]
        public string SignShortUrl { get; set; }

        /// <summary>
        /// 签署长链地址(永久有效)
        /// </summary>
        [JsonPropertyName("sign_url")]
        public string SignUrl { get; set; }
    }
}
