using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// CardPriceRequestItem Data Structure.
    /// </summary>
    public class CardPriceRequestItem : AlipayObject
    {
        /// <summary>
        /// 优惠卡原价，单位为分
        /// </summary>
        [JsonPropertyName("base_price_cent")]
        public long BasePriceCent { get; set; }

        /// <summary>
        /// 优惠卡类型，枚举值为 mcard(月卡),ycard(年卡)
        /// </summary>
        [JsonPropertyName("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 进价(调用方建议价格)，单位为分
        /// </summary>
        [JsonPropertyName("default_promo_price_cent")]
        public long DefaultPromoPriceCent { get; set; }

        /// <summary>
        /// 优惠卡价格区间上限，单位为分
        /// </summary>
        [JsonPropertyName("high_price_cent")]
        public long HighPriceCent { get; set; }

        /// <summary>
        /// 优惠卡价格区间下限，单位为分
        /// </summary>
        [JsonPropertyName("lower_price_cent")]
        public long LowerPriceCent { get; set; }

        /// <summary>
        /// 是否定价，默认为true
        /// </summary>
        [JsonPropertyName("pricing")]
        public bool Pricing { get; set; }

        /// <summary>
        /// 用户是否可购买，默认为true
        /// </summary>
        [JsonPropertyName("visible")]
        public bool Visible { get; set; }
    }
}
