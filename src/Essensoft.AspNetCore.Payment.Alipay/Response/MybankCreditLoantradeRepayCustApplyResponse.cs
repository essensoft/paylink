using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// MybankCreditLoantradeRepayCustApplyResponse.
    /// </summary>
    public class MybankCreditLoantradeRepayCustApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 受理事件编号
        /// </summary>
        [JsonPropertyName("ev_seq_no")]
        public string EvSeqNo { get; set; }

        /// <summary>
        /// 贷款合约编号
        /// </summary>
        [JsonPropertyName("loan_ar_no")]
        public string LoanArNo { get; set; }
    }
}
