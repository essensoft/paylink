using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// GoodsInformation Data Structure.
    /// </summary>
    [Serializable]
    public class GoodsInformation : AlipayObject
    {
        /// <summary>
        /// 购买的商品个数
        /// </summary>
        [JsonProperty("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 基于alipay商品库的skuId
        /// </summary>
        [JsonProperty("sku_id")]
        public string SkuId { get; set; }
    }
}
