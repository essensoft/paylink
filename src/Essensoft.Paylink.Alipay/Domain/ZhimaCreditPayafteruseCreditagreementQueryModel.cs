using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ZhimaCreditPayafteruseCreditagreementQueryModel Data Structure.
    /// </summary>
    public class ZhimaCreditPayafteruseCreditagreementQueryModel : AlipayObject
    {
        /// <summary>
        /// 芝麻授权id，out_request_no与credit_agreement_id必填一个，推荐使用credit_agreement_id。
        /// </summary>
        [JsonPropertyName("credit_agreement_id")]
        public string CreditAgreementId { get; set; }

        /// <summary>
        /// 商户外部协议号
        /// </summary>
        [JsonPropertyName("out_agreement_no")]
        public string OutAgreementNo { get; set; }
    }
}
