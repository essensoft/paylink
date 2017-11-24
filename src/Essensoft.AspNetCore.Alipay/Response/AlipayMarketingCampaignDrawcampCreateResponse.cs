using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingCampaignDrawcampCreateResponse.
    /// </summary>
    public class AlipayMarketingCampaignDrawcampCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 抽奖活动id
        /// </summary>
        [JsonProperty("camp_id")]
        public string CampId { get; set; }
    }
}
