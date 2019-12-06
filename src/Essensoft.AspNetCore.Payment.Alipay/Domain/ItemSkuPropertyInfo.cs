using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ItemSkuPropertyInfo Data Structure.
    /// </summary>
    public class ItemSkuPropertyInfo : AlipayObject
    {
        /// <summary>
        /// 属性
        /// </summary>
        [JsonPropertyName("property_key")]
        public string PropertyKey { get; set; }

        /// <summary>
        /// 属性值
        /// </summary>
        [JsonPropertyName("property_value")]
        public string PropertyValue { get; set; }
    }
}
