using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayPcreditLoanRepayApplyResponse.
    /// </summary>
    public class AlipayPcreditLoanRepayApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 跳转至支付宝地址
        /// </summary>
        [JsonPropertyName("redirect_url")]
        public string RedirectUrl { get; set; }

        /// <summary>
        /// 还款申请受理单号
        /// </summary>
        [JsonPropertyName("repay_receipt_no")]
        public string RepayReceiptNo { get; set; }
    }
}
