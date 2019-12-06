using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingCardBenefitModifyModel Data Structure.
    /// </summary>
    public class AlipayMarketingCardBenefitModifyModel : AlipayObject
    {
        /// <summary>
        /// 权益ID
        /// </summary>
        [JsonPropertyName("benefit_id")]
        public string BenefitId { get; set; }

        /// <summary>
        /// 会员卡模板外部权益
        /// </summary>
        [JsonPropertyName("mcard_template_benefit")]
        public McardTemplateBenefit McardTemplateBenefit { get; set; }
    }
}
