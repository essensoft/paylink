using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignIntelligentPromoModifyModel Data Structure.
    /// </summary>
    public class KoubeiMarketingCampaignIntelligentPromoModifyModel : AlipayObject
    {
        /// <summary>
        /// 操作人员上下文
        /// </summary>
        [JsonPropertyName("operator_context")]
        public PromoOperatorInfo OperatorContext { get; set; }

        /// <summary>
        /// 代表了一次请求，作为业务幂等性控制
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 方案信息
        /// </summary>
        [JsonPropertyName("promo")]
        public IntelligentPromo Promo { get; set; }
    }
}
