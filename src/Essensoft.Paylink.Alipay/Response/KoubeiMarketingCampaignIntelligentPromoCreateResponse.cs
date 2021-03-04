using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignIntelligentPromoCreateResponse.
    /// </summary>
    public class KoubeiMarketingCampaignIntelligentPromoCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 智能营销活动信息
        /// </summary>
        [JsonPropertyName("promo")]
        public IntelligentPromo Promo { get; set; }
    }
}
