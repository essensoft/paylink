using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// HelloBikePriceConstraint Data Structure.
    /// </summary>
    [Serializable]
    public class HelloBikePriceConstraint : AlipayObject
    {
        /// <summary>
        /// 优惠卡原价，单位为分
        /// </summary>
        [JsonProperty("base_price_cent")]
        public long BasePriceCent { get; set; }

        /// <summary>
        /// 优惠卡类型，枚举值为 mcard,qcard,hycard,ycard,tcard
        /// </summary>
        [JsonProperty("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 默认优惠卡打折后的价格，单位为分
        /// </summary>
        [JsonProperty("default_promo_price_cent")]
        public long DefaultPromoPriceCent { get; set; }

        /// <summary>
        /// 优惠卡价格区间上限，单位为分
        /// </summary>
        [JsonProperty("high_price_cent")]
        public long HighPriceCent { get; set; }

        /// <summary>
        /// 优惠卡价格区间下限，单位为分
        /// </summary>
        [JsonProperty("lower_price_cent")]
        public long LowerPriceCent { get; set; }

        /// <summary>
        /// 是否定价
        /// </summary>
        [JsonProperty("pricing")]
        public bool Pricing { get; set; }

        /// <summary>
        /// 用户是否可购买
        /// </summary>
        [JsonProperty("visible")]
        public bool Visible { get; set; }
    }
}
