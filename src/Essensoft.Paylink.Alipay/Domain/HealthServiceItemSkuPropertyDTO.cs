using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// HealthServiceItemSkuPropertyDTO Data Structure.
    /// </summary>
    public class HealthServiceItemSkuPropertyDTO : AlipayObject
    {
        /// <summary>
        /// SKU属性Key展示值
        /// </summary>
        [JsonPropertyName("sku_property_key_display")]
        public string SkuPropertyKeyDisplay { get; set; }

        /// <summary>
        /// SKU属性值展示值
        /// </summary>
        [JsonPropertyName("sku_property_value_display")]
        public string SkuPropertyValueDisplay { get; set; }
    }
}
