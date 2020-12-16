using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// HelloBikePriceResultItem Data Structure.
    /// </summary>
    public class HelloBikePriceResultItem : AlipayObject
    {
        /// <summary>
        /// 优惠卡类型，枚举值为 mcard,qcard,hycard,ycard,tcard
        /// </summary>
        [JsonPropertyName("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 排序优先级,数字越小,优先级越高,没有经过排序的卡类型默认返回-1
        /// </summary>
        [JsonPropertyName("priority")]
        public string Priority { get; set; }

        /// <summary>
        /// 推荐价格，单位为分
        /// </summary>
        [JsonPropertyName("promo_price_cent")]
        public long PromoPriceCent { get; set; }
    }
}
