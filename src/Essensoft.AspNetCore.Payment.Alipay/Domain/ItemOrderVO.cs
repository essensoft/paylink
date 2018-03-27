using Newtonsoft.Json;

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
        [JsonProperty("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 商品单ID
        /// </summary>
        [JsonProperty("item_order_no")]
        public string ItemOrderNo { get; set; }

        /// <summary>
        /// 商品单价
        /// </summary>
        [JsonProperty("price")]
        public string Price { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        [JsonProperty("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 商品skuId
        /// </summary>
        [JsonProperty("sku_id")]
        public string SkuId { get; set; }
    }
}
