using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ItemOrderVO Data Structure.
    /// </summary>
    public class ItemOrderVO : AlipayObject
    {
        /// <summary>
        /// 业务扩展信息，比如外部卡码，格式为json格式
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 商品单ID
        /// </summary>
        [JsonPropertyName("item_order_no")]
        public string ItemOrderNo { get; set; }

        /// <summary>
        /// 分摊至商品上的商户出资金额
        /// </summary>
        [JsonPropertyName("merchant_fund")]
        public string MerchantFund { get; set; }

        /// <summary>
        /// 分摊至商品上的平台出资金额
        /// </summary>
        [JsonPropertyName("platform_fund")]
        public string PlatformFund { get; set; }

        /// <summary>
        /// 商品单价
        /// </summary>
        [JsonPropertyName("price")]
        public string Price { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        [JsonPropertyName("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 商品skuId
        /// </summary>
        [JsonPropertyName("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// 商品单状态
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
