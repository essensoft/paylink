using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingCardBenefitCreateResponse.
    /// </summary>
    public class AlipayMarketingCardBenefitCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 权益ID
        /// </summary>
        [JsonPropertyName("benefit_id")]
        public string BenefitId { get; set; }
    }
}
