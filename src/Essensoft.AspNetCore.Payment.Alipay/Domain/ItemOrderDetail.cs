using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ItemOrderDetail Data Structure.
    /// </summary>
    [Serializable]
    public class ItemOrderDetail : AlipayObject
    {
        /// <summary>
        /// 商品原价，单位元，精确到小数点后两位
        /// </summary>
        [JsonProperty("original_price")]
        public string OriginalPrice { get; set; }

        /// <summary>
        /// 商品现价，即商品售价，单位为元，精确到小数点后两位
        /// </summary>
        [JsonProperty("price")]
        public string Price { get; set; }

        /// <summary>
        /// 购买商品数量
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
