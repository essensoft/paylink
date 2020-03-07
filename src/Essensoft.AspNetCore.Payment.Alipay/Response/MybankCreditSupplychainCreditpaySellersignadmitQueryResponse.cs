using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// MybankCreditSupplychainCreditpaySellersignadmitQueryResponse.
    /// </summary>
    public class MybankCreditSupplychainCreditpaySellersignadmitQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 准入/不准入:true/false
        /// </summary>
        [JsonPropertyName("admit")]
        public bool Admit { get; set; }

        /// <summary>
        /// 网商日志跟踪ID
        /// </summary>
        [JsonPropertyName("trace_id")]
        public string TraceId { get; set; }

        /// <summary>
        /// 签约不准入原因
        /// </summary>
        [JsonPropertyName("unadmit_reason")]
        public string UnadmitReason { get; set; }
    }
}
