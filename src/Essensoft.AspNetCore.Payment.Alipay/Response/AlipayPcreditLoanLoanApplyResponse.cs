using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayPcreditLoanLoanApplyResponse.
    /// </summary>
    public class AlipayPcreditLoanLoanApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 贷款申请受理单号
        /// </summary>
        [JsonPropertyName("apply_receipt_no")]
        public string ApplyReceiptNo { get; set; }

        /// <summary>
        /// 跳转至支付宝地址
        /// </summary>
        [JsonPropertyName("redirect_url")]
        public string RedirectUrl { get; set; }
    }
}
