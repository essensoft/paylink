using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// MybankCreditSupplychainCreditpaySellerunsignQueryResponse.
    /// </summary>
    public class MybankCreditSupplychainCreditpaySellerunsignQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 是否可解约
        /// </summary>
        [JsonPropertyName("admit")]
        public bool Admit { get; set; }

        /// <summary>
        /// 日志id
        /// </summary>
        [JsonPropertyName("trace_id")]
        public string TraceId { get; set; }

        /// <summary>
        /// 不可解约原因码，解约失败时返回
        /// </summary>
        [JsonPropertyName("unadmit_reason")]
        public string UnadmitReason { get; set; }
    }
}
