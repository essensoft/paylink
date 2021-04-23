using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// ZhimaCreditPeZmgoAgreementQueryResponse.
    /// </summary>
    public class ZhimaCreditPeZmgoAgreementQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝系统中用以唯一标识用户签约记录的编号，即花芝轻会员协议号。
        /// </summary>
        [JsonPropertyName("agreement_id")]
        public string AgreementId { get; set; }

        /// <summary>
        /// 协议名称
        /// </summary>
        [JsonPropertyName("agreement_name")]
        public string AgreementName { get; set; }

        /// <summary>
        /// 协议状态。Y表示状态有效，N表示状态失效
        /// </summary>
        [JsonPropertyName("agreement_status")]
        public string AgreementStatus { get; set; }

        /// <summary>
        /// 支付宝用户userId
        /// </summary>
        [JsonPropertyName("alipay_user_id")]
        public string AlipayUserId { get; set; }
    }
}
