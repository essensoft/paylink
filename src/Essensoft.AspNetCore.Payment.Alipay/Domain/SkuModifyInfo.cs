using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SkuModifyInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SkuModifyInfo : AlipayObject
    {
        /// <summary>
        /// 库存
        /// </summary>
        [JsonProperty("inventory")]
        public long Inventory { get; set; }

        /// <summary>
        /// SKU素材列表（会和SKU已存在素材做差异化比较后做增删改操作）
        /// </summary>
        [JsonProperty("material_list")]
        public List<MaterialModifyInfo> MaterialList { get; set; }

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
        /// SKU属性列表（覆盖SKU已存在属性）
        /// </summary>
        [JsonProperty("property_list")]
        public List<ItemSkuPropertyInfo> PropertyList { get; set; }

        /// <summary>
        /// SKU ID（传空表示新增对应SKU）
        /// </summary>
        [JsonProperty("sku_id")]
        public string SkuId { get; set; }
    }
}
