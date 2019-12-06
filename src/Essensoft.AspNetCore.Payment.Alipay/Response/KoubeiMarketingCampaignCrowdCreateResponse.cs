using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignCrowdCreateResponse.
    /// </summary>
    public class KoubeiMarketingCampaignCrowdCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 返回的人群组的唯一标识
        /// </summary>
        [JsonPropertyName("crowd_group_id")]
        public string CrowdGroupId { get; set; }
    }
}
