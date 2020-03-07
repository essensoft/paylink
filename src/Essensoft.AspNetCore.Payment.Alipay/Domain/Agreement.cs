using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Agreement Data Structure.
    /// </summary>
    public class Agreement : AlipayObject
    {
        /// <summary>
        /// 协议地址
        /// </summary>
        [JsonPropertyName("link")]
        public string Link { get; set; }

        /// <summary>
        /// 协议名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
