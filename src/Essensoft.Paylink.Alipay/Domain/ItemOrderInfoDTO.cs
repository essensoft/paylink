using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ItemOrderInfoDTO Data Structure.
    /// </summary>
    public class ItemOrderInfoDTO : AlipayObject
    {
        /// <summary>
        /// 商品条形码
        /// </summary>
        [JsonPropertyName("barcode")]
        public string Barcode { get; set; }

        /// <summary>
        /// 商品 id
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品名称; 使用支付宝电子小票时，必填;（is_alipay_ticket 是 "1"时，必填）
        /// </summary>
        [JsonPropertyName("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 商品数量（单位：自拟）;使用支付宝电子小票时，必填;（is_alipay_ticket 是 "1"时，必填）
        /// </summary>
        [JsonPropertyName("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 商品 sku id
        /// </summary>
        [JsonPropertyName("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// 商品单价（单位: 元）;使用支付宝电子小票时，必填;（is_alipay_ticket 是 "1"时，必填）
        /// </summary>
        [JsonPropertyName("unit_price")]
        public string UnitPrice { get; set; }
    }
}
