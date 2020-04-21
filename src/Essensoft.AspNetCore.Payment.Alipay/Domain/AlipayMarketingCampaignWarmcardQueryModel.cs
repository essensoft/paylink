using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignWarmcardQueryModel Data Structure.
    /// </summary>
    public class AlipayMarketingCampaignWarmcardQueryModel : AlipayObject
    {
        /// <summary>
        /// 春暖花开活动场景码
        /// </summary>
        [JsonPropertyName("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
