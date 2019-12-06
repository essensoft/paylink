using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayPcreditLoanRefundCreateResponse.
    /// </summary>
    public class AlipayPcreditLoanRefundCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 受理的还款申请单号
        /// </summary>
        [JsonPropertyName("loan_repay_no")]
        public string LoanRepayNo { get; set; }
    }
}
