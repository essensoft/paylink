using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserAgreementExecutionplanModifyResponse.
    /// </summary>
    public class AlipayUserAgreementExecutionplanModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 周期性扣款产品，授权免密支付协议号
        /// </summary>
        [JsonPropertyName("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 商户下一次扣款时间
        /// </summary>
        [JsonPropertyName("deduct_time")]
        public string DeductTime { get; set; }
    }
}
