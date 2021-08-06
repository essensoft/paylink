using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// SearchProductOrientedRule Data Structure.
    /// </summary>
    public class SearchProductOrientedRule : AlipayObject
    {
        /// <summary>
        /// 客户端
        /// </summary>
        [JsonPropertyName("client_platform")]
        public string ClientPlatform { get; set; }

        /// <summary>
        /// 结束版本
        /// </summary>
        [JsonPropertyName("end_version")]
        public string EndVersion { get; set; }

        /// <summary>
        /// 开始版本
        /// </summary>
        [JsonPropertyName("start_version")]
        public string StartVersion { get; set; }
    }
}
