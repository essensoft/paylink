using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SkuCreateInfo Data Structure.
    /// </summary>
    public class SkuCreateInfo : AlipayObject
    {
        /// <summary>
        /// 库存
        /// </summary>
        [JsonPropertyName("inventory")]
        public long Inventory { get; set; }

        /// <summary>
        /// SKU素材列表（最多3个）
        /// </summary>
        [JsonPropertyName("material_list")]
        public List<MaterialCreateInfo> MaterialList { get; set; }

        /// <summary>
        /// 标价，单位分
        /// </summary>
        [JsonPropertyName("original_price")]
        public long OriginalPrice { get; set; }

        /// <summary>
        /// 售价，单位分
        /// </summary>
        [JsonPropertyName("price")]
        public long Price { get; set; }

        /// <summary>
        /// SKU属性列表
        /// </summary>
        [JsonPropertyName("property_list")]
        public List<ItemSkuPropertyInfo> PropertyList { get; set; }
    }
}
