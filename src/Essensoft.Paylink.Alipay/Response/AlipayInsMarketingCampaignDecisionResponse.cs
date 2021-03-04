using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayInsMarketingCampaignDecisionResponse.
    /// </summary>
    public class AlipayInsMarketingCampaignDecisionResponse : AlipayResponse
    {
        /// <summary>
        /// 保险营销标的关联的活动列表
        /// </summary>
        [JsonPropertyName("mkt_campaigns")]
        public List<InsMktCampaignDTO> MktCampaigns { get; set; }
    }
}
