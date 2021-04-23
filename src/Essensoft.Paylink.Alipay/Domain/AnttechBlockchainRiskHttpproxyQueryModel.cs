using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AnttechBlockchainRiskHttpproxyQueryModel Data Structure.
    /// </summary>
    public class AnttechBlockchainRiskHttpproxyQueryModel : AlipayObject
    {
        /// <summary>
        /// char set
        /// </summary>
        [JsonPropertyName("char_set")]
        public string CharSet { get; set; }

        /// <summary>
        /// content type
        /// </summary>
        [JsonPropertyName("content_type")]
        public string ContentType { get; set; }

        /// <summary>
        /// http body参数
        /// </summary>
        [JsonPropertyName("data")]
        public string Data { get; set; }

        /// <summary>
        /// http请求头
        /// </summary>
        [JsonPropertyName("headers")]
        public string Headers { get; set; }

        /// <summary>
        /// http 方法
        /// </summary>
        [JsonPropertyName("http_method")]
        public string HttpMethod { get; set; }

        /// <summary>
        /// url参数
        /// </summary>
        [JsonPropertyName("params")]
        public string Params { get; set; }

        /// <summary>
        /// 请求url地址
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
