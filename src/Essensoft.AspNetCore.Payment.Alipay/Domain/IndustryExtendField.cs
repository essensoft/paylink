using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// IndustryExtendField Data Structure.
    /// </summary>
    public class IndustryExtendField : AlipayObject
    {
        /// <summary>
        /// 扩展参数的key值
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; }

        /// <summary>
        /// 扩展参数的value值
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
