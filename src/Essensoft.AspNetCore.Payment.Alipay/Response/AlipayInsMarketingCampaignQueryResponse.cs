using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayInsMarketingCampaignQueryResponse.
    /// </summary>
    public class AlipayInsMarketingCampaignQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 保险营销活动信息
        /// </summary>
        [JsonPropertyName("mkt_campaign")]
        public InsMktCampaignDTO MktCampaign { get; set; }
    }
}
