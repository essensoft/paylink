using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SkuCreateInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SkuCreateInfo : AlipayObject
    {
        /// <summary>
        /// 库存
        /// </summary>
        [JsonProperty("inventory")]
        public long Inventory { get; set; }

        /// <summary>
        /// SKU素材列表（最多3个）
        /// </summary>
        [JsonProperty("material_list")]
        public List<MaterialCreateInfo> MaterialList { get; set; }

        /// <summary>
        /// 标价，单位分
        /// </summary>
        [JsonProperty("original_price")]
        public long OriginalPrice { get; set; }

        /// <summary>
        /// 售价，单位分
        /// </summary>
        [JsonProperty("price")]
        public long Price { get; set; }

        /// <summary>
        /// SKU属性列表
        /// </summary>
        [JsonProperty("property_list")]
        public List<ItemSkuPropertyInfo> PropertyList { get; set; }
    }
}
