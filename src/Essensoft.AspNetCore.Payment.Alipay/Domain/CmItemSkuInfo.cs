using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CmItemSkuInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CmItemSkuInfo : AlipayObject
    {
        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 库存
        /// </summary>
        [JsonProperty("inventory")]
        public long Inventory { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [JsonProperty("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 素材列表
        /// </summary>
        [JsonProperty("material_list")]
        public List<MaterialInfo> MaterialList { get; set; }

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
        /// 剩余库存
        /// </summary>
        [JsonProperty("remain_inventory")]
        public long RemainInventory { get; set; }

        /// <summary>
        /// 商品SKU ID
        /// </summary>
        [JsonProperty("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// SKU属性列表
        /// </summary>
        [JsonProperty("sku_property_list")]
        public List<ItemSkuPropertyInfo> SkuPropertyList { get; set; }

        /// <summary>
        /// 商品SKU状态：  EFFECT(有效)、  INVALID（无效）
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
