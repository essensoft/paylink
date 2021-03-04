using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignActivityQueryResponse.
    /// </summary>
    public class KoubeiMarketingCampaignActivityQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 活动详情
        /// </summary>
        [JsonPropertyName("camp_detail")]
        public CampDetail CampDetail { get; set; }
    }
}
