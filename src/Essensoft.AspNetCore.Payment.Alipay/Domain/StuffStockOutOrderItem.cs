using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// StuffStockOutOrderItem Data Structure.
    /// </summary>
    public class StuffStockOutOrderItem : AlipayObject
    {
        /// <summary>
        /// 扩展字段
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonPropertyName("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 发货数量
        /// </summary>
        [JsonPropertyName("item_quantity")]
        public long ItemQuantity { get; set; }

        /// <summary>
        /// sku号
        /// </summary>
        [JsonPropertyName("sku_no")]
        public string SkuNo { get; set; }
    }
}
