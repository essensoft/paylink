using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Response
{
    /// <summary>
    /// AlipayPcreditLoanRefundCreateResponse.
    /// </summary>
    public class AlipayPcreditLoanRefundCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 受理的还款申请单号
        /// </summary>
        [JsonProperty("loan_repay_no")]
        public string LoanRepayNo { get; set; }
    }
}
