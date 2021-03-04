using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// MybankCreditLoantradeRepayInitiativeApplyResponse.
    /// </summary>
    public class MybankCreditLoantradeRepayInitiativeApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 受理事件单编号。
        /// </summary>
        [JsonPropertyName("ev_seq_no")]
        public string EvSeqNo { get; set; }
    }
}
