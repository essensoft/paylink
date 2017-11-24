using Newtonsoft.Json;
using Essensoft.AspNetCore.Alipay.Domain;

namespace Essensoft.AspNetCore.Alipay.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignIntelligentPromoModifyResponse.
    /// </summary>
    public class KoubeiMarketingCampaignIntelligentPromoModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 修改后返回的智能活动模型
        /// </summary>
        [JsonProperty("promo")]
        public IntelligentPromo Promo { get; set; }
    }
}
