using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingToolPointsQueryModel Data Structure.
    /// </summary>
    public class KoubeiMarketingToolPointsQueryModel : AlipayObject
    {
        /// <summary>
        /// 活动积分帐户
        /// </summary>
        [JsonPropertyName("activity_account")]
        public string ActivityAccount { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
