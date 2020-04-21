using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingToolPrizesendAuthModel Data Structure.
    /// </summary>
    public class KoubeiMarketingToolPrizesendAuthModel : AlipayObject
    {
        /// <summary>
        /// 奖品ID
        /// </summary>
        [JsonPropertyName("prize_id")]
        public string PrizeId { get; set; }

        /// <summary>
        /// 外部流水号，保证业务幂等性
        /// </summary>
        [JsonPropertyName("req_id")]
        public string ReqId { get; set; }

        /// <summary>
        /// 发奖用户ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
