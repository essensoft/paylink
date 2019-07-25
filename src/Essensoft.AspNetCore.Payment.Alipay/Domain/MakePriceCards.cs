using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MakePriceCards Data Structure.
    /// </summary>
    [Serializable]
    public class MakePriceCards : AlipayObject
    {
        /// <summary>
        /// 定价对象原价
        /// </summary>
        [JsonProperty("base_price_cent")]
        public long BasePriceCent { get; set; }

        /// <summary>
        /// 期望推荐价格，注意：不要频繁变动。
        /// </summary>
        [JsonProperty("expect_promo_price")]
        public string ExpectPromoPrice { get; set; }

        /// <summary>
        /// 定价区间下限
        /// </summary>
        [JsonProperty("lower_promo_price")]
        public long LowerPromoPrice { get; set; }

        /// <summary>
        /// 定价对象类型
        /// </summary>
        [JsonProperty("product_type")]
        public string ProductType { get; set; }

        /// <summary>
        /// 定价区间上限
        /// </summary>
        [JsonProperty("upper_promo_price")]
        public long UpperPromoPrice { get; set; }
    }
}
