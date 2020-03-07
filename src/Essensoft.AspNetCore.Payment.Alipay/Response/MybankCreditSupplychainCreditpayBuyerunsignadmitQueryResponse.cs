using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// MybankCreditSupplychainCreditpayBuyerunsignadmitQueryResponse.
    /// </summary>
    public class MybankCreditSupplychainCreditpayBuyerunsignadmitQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 能否解约：true/false
        /// </summary>
        [JsonPropertyName("admit")]
        public bool Admit { get; set; }

        /// <summary>
        /// 网商日志跟踪ID
        /// </summary>
        [JsonPropertyName("trace_id")]
        public string TraceId { get; set; }

        /// <summary>
        /// 不可解约原因码，失败时返回
        /// </summary>
        [JsonPropertyName("unadmit_reason")]
        public string UnadmitReason { get; set; }
    }
}
