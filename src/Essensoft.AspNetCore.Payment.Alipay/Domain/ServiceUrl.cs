using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ServiceUrl Data Structure.
    /// </summary>
    public class ServiceUrl : AlipayObject
    {
        /// <summary>
        /// 类型
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// URL
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
