using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// HelloBikePriceCondition Data Structure.
    /// </summary>
    public class HelloBikePriceCondition : AlipayObject
    {
        /// <summary>
        /// 算式左侧优惠卡类型，枚举值为 mcard,qcard,hycard,ycard,tcard
        /// </summary>
        [JsonPropertyName("card_type_left")]
        public string CardTypeLeft { get; set; }

        /// <summary>
        /// 算式右侧优惠卡类型，枚举值为 mcard,qcard,hycard,ycard,tcard
        /// </summary>
        [JsonPropertyName("card_type_right")]
        public string CardTypeRight { get; set; }

        /// <summary>
        /// 算式左侧系数，字符串表示的浮点数，保留5位小数
        /// </summary>
        [JsonPropertyName("coefficient_left")]
        public string CoefficientLeft { get; set; }

        /// <summary>
        /// 算式右侧系数，字符串表示的浮点数，保留5位小数
        /// </summary>
        [JsonPropertyName("coefficient_right")]
        public string CoefficientRight { get; set; }
    }
}
