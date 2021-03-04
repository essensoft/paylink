using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayFundCouponWufuCardAcceptResponse.
    /// </summary>
    public class AlipayFundCouponWufuCardAcceptResponse : AlipayResponse
    {
        /// <summary>
        /// 福卡名称
        /// </summary>
        [JsonPropertyName("card_name")]
        public string CardName { get; set; }

        /// <summary>
        /// 福卡类型
        /// </summary>
        [JsonPropertyName("card_type")]
        public string CardType { get; set; }
    }
}
