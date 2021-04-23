using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// ZhimaCreditPayafteruseCreditagreementSignResponse.
    /// </summary>
    public class ZhimaCreditPayafteruseCreditagreementSignResponse : AlipayResponse
    {
        /// <summary>
        /// 芝麻协议号
        /// </summary>
        [JsonPropertyName("credit_agreement_id")]
        public string CreditAgreementId { get; set; }

        /// <summary>
        /// 外部请求号
        /// </summary>
        [JsonPropertyName("out_agreement_no")]
        public string OutAgreementNo { get; set; }
    }
}
