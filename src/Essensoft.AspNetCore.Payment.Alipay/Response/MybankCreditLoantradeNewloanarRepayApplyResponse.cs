using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// MybankCreditLoantradeNewloanarRepayApplyResponse.
    /// </summary>
    public class MybankCreditLoantradeNewloanarRepayApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 受理事件编号
        /// </summary>
        [JsonPropertyName("ev_seq_no")]
        public string EvSeqNo { get; set; }

        /// <summary>
        /// 合约编号
        /// </summary>
        [JsonPropertyName("loan_ar_no")]
        public string LoanArNo { get; set; }
    }
}
