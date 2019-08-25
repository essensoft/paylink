using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ItemOrderInfoResult Data Structure.
    /// </summary>
    [Serializable]
    public class ItemOrderInfoResult : AlipayObject
    {
        /// <summary>
        /// 商品图片链接
        /// </summary>
        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonProperty("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 商户商品链接
        /// </summary>
        [JsonProperty("merchant_item_link_page")]
        public string MerchantItemLinkPage { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        [JsonProperty("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 商品单价（单位：元）
        /// </summary>
        [JsonProperty("unit_price")]
        public string UnitPrice { get; set; }
    }
}
