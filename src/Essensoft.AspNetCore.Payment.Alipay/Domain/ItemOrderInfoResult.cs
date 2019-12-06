using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ItemOrderInfoResult Data Structure.
    /// </summary>
    public class ItemOrderInfoResult : AlipayObject
    {
        /// <summary>
        /// 商品图片链接
        /// </summary>
        [JsonPropertyName("image_url")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonPropertyName("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 商户商品链接
        /// </summary>
        [JsonPropertyName("merchant_item_link_page")]
        public string MerchantItemLinkPage { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        [JsonPropertyName("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 商品单价（单位：元）
        /// </summary>
        [JsonPropertyName("unit_price")]
        public string UnitPrice { get; set; }
    }
}
