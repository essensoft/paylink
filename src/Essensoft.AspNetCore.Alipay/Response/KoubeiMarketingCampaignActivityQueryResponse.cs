using Newtonsoft.Json;
using Essensoft.AspNetCore.Alipay.Domain;

namespace Essensoft.AspNetCore.Alipay.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignActivityQueryResponse.
    /// </summary>
    public class KoubeiMarketingCampaignActivityQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 活动详情
        /// </summary>
        [JsonProperty("camp_detail")]
        public CampDetail CampDetail { get; set; }
    }
}
