using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// HelloBikePriceResultItem Data Structure.
    /// </summary>
    [Serializable]
    public class HelloBikePriceResultItem : AlipayObject
    {
        /// <summary>
        /// 优惠卡类型，枚举值为 mcard,qcard,hycard,ycard,tcard
        /// </summary>
        [JsonProperty("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 推荐价格，单位为分
        /// </summary>
        [JsonProperty("promo_price_cent")]
        public long PromoPriceCent { get; set; }
    }
}
