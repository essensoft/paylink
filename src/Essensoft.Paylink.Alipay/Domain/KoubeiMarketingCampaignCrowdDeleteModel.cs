using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignCrowdDeleteModel Data Structure.
    /// </summary>
    public class KoubeiMarketingCampaignCrowdDeleteModel : AlipayObject
    {
        /// <summary>
        /// 人群组的唯一标识ID
        /// </summary>
        [JsonPropertyName("crowd_group_id")]
        public string CrowdGroupId { get; set; }
    }
}
