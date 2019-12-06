using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignDrawcampQueryModel Data Structure.
    /// </summary>
    public class AlipayMarketingCampaignDrawcampQueryModel : AlipayObject
    {
        /// <summary>
        /// 抽奖活动id，通过alipay.marketing.campaign.drawcamp.create接口返回
        /// </summary>
        [JsonPropertyName("camp_id")]
        public string CampId { get; set; }
    }
}
