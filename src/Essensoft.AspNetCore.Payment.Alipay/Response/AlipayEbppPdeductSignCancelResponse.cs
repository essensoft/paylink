using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEbppPdeductSignCancelResponse.
    /// </summary>
    public class AlipayEbppPdeductSignCancelResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝代扣协议ID
        /// </summary>
        [JsonPropertyName("agreement_id")]
        public string AgreementId { get; set; }

        /// <summary>
        /// 支付宝协议状态。解约成功则返回success
        /// </summary>
        [JsonPropertyName("agreement_status")]
        public string AgreementStatus { get; set; }

        /// <summary>
        /// 商户代扣协议ID
        /// </summary>
        [JsonPropertyName("out_agreement_id")]
        public string OutAgreementId { get; set; }
    }
}
