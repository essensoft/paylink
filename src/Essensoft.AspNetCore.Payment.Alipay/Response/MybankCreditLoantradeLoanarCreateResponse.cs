using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// MybankCreditLoantradeLoanarCreateResponse.
    /// </summary>
    public class MybankCreditLoantradeLoanarCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 事件流水号
        /// </summary>
        [JsonPropertyName("ev_seq_no")]
        public string EvSeqNo { get; set; }

        /// <summary>
        /// 贷款合约号
        /// </summary>
        [JsonPropertyName("loan_ar_no")]
        public string LoanArNo { get; set; }
    }
}
