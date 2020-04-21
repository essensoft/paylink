using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ItemExtInfo Data Structure.
    /// </summary>
    public class ItemExtInfo : AlipayObject
    {
        /// <summary>
        /// 扩展信息的key
        /// </summary>
        [JsonPropertyName("ext_key")]
        public string ExtKey { get; set; }

        /// <summary>
        /// 扩展信息的值
        /// </summary>
        [JsonPropertyName("ext_value")]
        public string ExtValue { get; set; }
    }
}
