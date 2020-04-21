using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignIntelligentPromoDeleteModel Data Structure.
    /// </summary>
    public class KoubeiMarketingCampaignIntelligentPromoDeleteModel : AlipayObject
    {
        /// <summary>
        /// 操作下架的操作人信息
        /// </summary>
        [JsonPropertyName("operator_context")]
        public PromoOperatorInfo OperatorContext { get; set; }

        /// <summary>
        /// 代表了一次请求，作为业务幂等性控制
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 智能营销活动的id
        /// </summary>
        [JsonPropertyName("promo_id")]
        public string PromoId { get; set; }
    }
}
