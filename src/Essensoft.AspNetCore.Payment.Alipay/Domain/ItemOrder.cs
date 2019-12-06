using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ItemOrder Data Structure.
    /// </summary>
    public class ItemOrder : AlipayObject
    {
        /// <summary>
        /// 扩展信息（键值对列表，有重复的键后者覆盖前者，建议唯一，以免出现不可预期的结果）
        /// </summary>
        [JsonPropertyName("ext_info")]
        public List<OrderExtInfo> ExtInfo { get; set; }

        /// <summary>
        /// 商品 id
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonPropertyName("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 商品数量（单位：自拟）
        /// </summary>
        [JsonPropertyName("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 实付金额（单位：分）
        /// </summary>
        [JsonPropertyName("real_amount")]
        public long RealAmount { get; set; }

        /// <summary>
        /// 商品 sku id
        /// </summary>
        [JsonPropertyName("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// 商品补贴金额（单位：分）
        /// </summary>
        [JsonPropertyName("subsidy_amount")]
        public long SubsidyAmount { get; set; }

        /// <summary>
        /// 商品单价（单位：分）
        /// </summary>
        [JsonPropertyName("unit_price")]
        public long UnitPrice { get; set; }
    }
}
