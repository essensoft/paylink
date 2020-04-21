using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsMarketingCampaignQueryModel Data Structure.
    /// </summary>
    public class AlipayInsMarketingCampaignQueryModel : AlipayObject
    {
        /// <summary>
        /// 保险营销活动Id
        /// </summary>
        [JsonPropertyName("campaign_id")]
        public string CampaignId { get; set; }

        /// <summary>
        /// 请求流水Id
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }
    }
}
