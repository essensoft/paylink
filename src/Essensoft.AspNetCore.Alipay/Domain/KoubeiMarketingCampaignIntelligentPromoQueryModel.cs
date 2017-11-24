using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignIntelligentPromoQueryModel Data Structure.
    /// </summary>
    public class KoubeiMarketingCampaignIntelligentPromoQueryModel : AlipayObject
    {
        /// <summary>
        /// 操作人员上下文
        /// </summary>
        [JsonProperty("operator_context")]
        public PromoOperatorInfo OperatorContext { get; set; }

        /// <summary>
        /// 智能营销活动id
        /// </summary>
        [JsonProperty("promo_id")]
        public string PromoId { get; set; }
    }
}
