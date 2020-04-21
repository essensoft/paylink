using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignDiscountWhitelistUpdateModel Data Structure.
    /// </summary>
    public class AlipayMarketingCampaignDiscountWhitelistUpdateModel : AlipayObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [JsonPropertyName("camp_id")]
        public string CampId { get; set; }

        /// <summary>
        /// 白名单。逗号分隔开
        /// </summary>
        [JsonPropertyName("user_white_list")]
        public string UserWhiteList { get; set; }
    }
}
