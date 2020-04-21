using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CmItemSkuInfo Data Structure.
    /// </summary>
    public class CmItemSkuInfo : AlipayObject
    {
        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonPropertyName("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonPropertyName("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 库存
        /// </summary>
        [JsonPropertyName("inventory")]
        public long Inventory { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 素材列表
        /// </summary>
        [JsonPropertyName("material_list")]
        public List<MaterialInfo> MaterialList { get; set; }

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
        /// 剩余库存
        /// </summary>
        [JsonPropertyName("remain_inventory")]
        public long RemainInventory { get; set; }

        /// <summary>
        /// 商品SKU ID
        /// </summary>
        [JsonPropertyName("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// SKU属性列表
        /// </summary>
        [JsonPropertyName("sku_property_list")]
        public List<ItemSkuPropertyInfo> SkuPropertyList { get; set; }

        /// <summary>
        /// 商品SKU状态：  EFFECT(有效)、  INVALID（无效）
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
