using Newtonsoft.Json;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignIntelligentPromoCreateResponse.
    /// </summary>
    public class KoubeiMarketingCampaignIntelligentPromoCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 智能营销活动信息
        /// </summary>
        [JsonProperty("promo")]
        public IntelligentPromo Promo { get; set; }
    }
}
