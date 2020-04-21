using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayFundCouponWufuCardReceiveResponse.
    /// </summary>
    public class AlipayFundCouponWufuCardReceiveResponse : AlipayResponse
    {
        /// <summary>
        /// 福卡id，全局唯一
        /// </summary>
        [JsonPropertyName("card_id")]
        public string CardId { get; set; }

        /// <summary>
        /// 福卡类型:  1001=敬业福  1002=爱国福  1003=富强福  1004=和谐福  1005=友善福
        /// </summary>
        [JsonPropertyName("card_type")]
        public string CardType { get; set; }
    }
}
