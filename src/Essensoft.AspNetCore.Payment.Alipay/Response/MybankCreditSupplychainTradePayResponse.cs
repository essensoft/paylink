using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// MybankCreditSupplychainTradePayResponse.
    /// </summary>
    public class MybankCreditSupplychainTradePayResponse : AlipayResponse
    {
        /// <summary>
        /// 业务事件受理的流水号，建议调用方保持此流水号，以方便后续业务处理
        /// </summary>
        [JsonPropertyName("ev_seq_no")]
        public string EvSeqNo { get; set; }
    }
}
