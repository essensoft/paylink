using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignIntelligentPromoQueryModel Data Structure.
    /// </summary>
    public class KoubeiMarketingCampaignIntelligentPromoQueryModel : AlipayObject
    {
        /// <summary>
        /// 操作人员上下文
        /// </summary>
        [JsonPropertyName("operator_context")]
        public PromoOperatorInfo OperatorContext { get; set; }

        /// <summary>
        /// 外部业务id，请保持足够复杂。主要为了定位数据来源
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 智能营销活动id
        /// </summary>
        [JsonPropertyName("promo_id")]
        public string PromoId { get; set; }
    }
}
