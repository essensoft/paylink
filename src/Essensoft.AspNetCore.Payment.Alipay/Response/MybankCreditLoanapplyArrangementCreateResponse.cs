using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// MybankCreditLoanapplyArrangementCreateResponse.
    /// </summary>
    public class MybankCreditLoanapplyArrangementCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 某些场景表示签约的帐号
        /// </summary>
        [JsonPropertyName("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 合约编号
        /// </summary>
        [JsonPropertyName("ar_no")]
        public string ArNo { get; set; }

        /// <summary>
        /// 业务事件受理的流水号，建议调用方保持此流水号，以方便后续业务处理
        /// </summary>
        [JsonPropertyName("ev_seq_no")]
        public string EvSeqNo { get; set; }
    }
}
