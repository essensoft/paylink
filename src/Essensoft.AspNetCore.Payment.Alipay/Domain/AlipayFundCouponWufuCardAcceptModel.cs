using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayFundCouponWufuCardAcceptModel Data Structure.
    /// </summary>
    public class AlipayFundCouponWufuCardAcceptModel : AlipayObject
    {
        /// <summary>
        /// 福卡ID
        /// </summary>
        [JsonPropertyName("card_id")]
        public string CardId { get; set; }

        /// <summary>
        /// 送卡人uid
        /// </summary>
        [JsonPropertyName("sender_user_id")]
        public string SenderUserId { get; set; }

        /// <summary>
        /// 请求来源
        /// </summary>
        [JsonPropertyName("source")]
        public string Source { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
