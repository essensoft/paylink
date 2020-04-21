using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MExtInfo Data Structure.
    /// </summary>
    public class MExtInfo : AlipayObject
    {
        /// <summary>
        /// 扩展信息key值
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; }

        /// <summary>
        /// 扩展信息value值
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
