using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// MybankCreditSupplychainCreditpaySellerunsignCreateResponse.
    /// </summary>
    public class MybankCreditSupplychainCreditpaySellerunsignCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 失败原因码，解约失败时返回
        /// </summary>
        [JsonPropertyName("fail_reason")]
        public string FailReason { get; set; }

        /// <summary>
        /// 是否可重试
        /// </summary>
        [JsonPropertyName("retry")]
        public bool Retry { get; set; }

        /// <summary>
        /// trace信息
        /// </summary>
        [JsonPropertyName("trace_id")]
        public string TraceId { get; set; }

        /// <summary>
        /// 解约结果：true/false
        /// </summary>
        [JsonPropertyName("unsign_result")]
        public bool UnsignResult { get; set; }
    }
}
