using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignDiscountStatusUpdateModel Data Structure.
    /// </summary>
    public class AlipayMarketingCampaignDiscountStatusUpdateModel : AlipayObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [JsonPropertyName("camp_id")]
        public string CampId { get; set; }

        /// <summary>
        /// 状态CAMP_PAUSED：暂停,CAMP_GOING 启动,CAMP_ENDED结束
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
