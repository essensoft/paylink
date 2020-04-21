using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingCampaignRuleCrowdCreateResponse.
    /// </summary>
    public class AlipayMarketingCampaignRuleCrowdCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 圈人规则id
        /// </summary>
        [JsonPropertyName("ruleid")]
        public string Ruleid { get; set; }
    }
}
