using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignIntelligentShopConsultModel Data Structure.
    /// </summary>
    public class KoubeiMarketingCampaignIntelligentShopConsultModel : AlipayObject
    {
        /// <summary>
        /// 操作上下文
        /// </summary>
        [JsonProperty("operator_context")]
        public PromoOperatorInfo OperatorContext { get; set; }

        /// <summary>
        /// 商户和支付宝交互时，用于代表支付宝分配给商户ID
        /// </summary>
        [JsonProperty("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 智能营销方案的方案模板id
        /// </summary>
        [JsonProperty("plan_id")]
        public string PlanId { get; set; }
    }
}
