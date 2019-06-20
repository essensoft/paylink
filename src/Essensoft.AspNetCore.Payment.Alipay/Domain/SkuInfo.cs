using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SkuInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SkuInfo : AlipayObject
    {
        /// <summary>
        /// 支付宝会员渠道销售的，以分为单位表示的价格，示例中是125.00元
        /// </summary>
        [JsonProperty("price_cent")]
        public long PriceCent { get; set; }

        /// <summary>
        /// 商品的划线价，以分为单位，12500表示125元
        /// </summary>
        [JsonProperty("reserve_price")]
        public long ReservePrice { get; set; }

        /// <summary>
        /// 商品的skuId
        /// </summary>
        [JsonProperty("sku_id")]
        public string SkuId { get; set; }
    }
}
