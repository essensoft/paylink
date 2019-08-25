using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MakePriceResult Data Structure.
    /// </summary>
    [Serializable]
    public class MakePriceResult : AlipayObject
    {
        /// <summary>
        /// 定价对象原价
        /// </summary>
        [JsonProperty("base_price_cent")]
        public string BasePriceCent { get; set; }

        /// <summary>
        /// 定价对象类型
        /// </summary>
        [JsonProperty("product_type")]
        public string ProductType { get; set; }

        /// <summary>
        /// 定价对象推荐价格
        /// </summary>
        [JsonProperty("promo_price")]
        public string PromoPrice { get; set; }
    }
}
