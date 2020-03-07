using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// MybankCreditSupplychainCreditpayBuyerunsignCreateResponse.
    /// </summary>
    public class MybankCreditSupplychainCreditpayBuyerunsignCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 失败原因码：解约失败时返回
        /// </summary>
        [JsonPropertyName("fail_reason")]
        public string FailReason { get; set; }

        /// <summary>
        /// 是否可以重试
        /// </summary>
        [JsonPropertyName("retry")]
        public bool Retry { get; set; }

        /// <summary>
        /// 网商日志跟踪ID
        /// </summary>
        [JsonPropertyName("trace_id")]
        public string TraceId { get; set; }

        /// <summary>
        /// 解约结果
        /// </summary>
        [JsonPropertyName("unsign_result")]
        public bool UnsignResult { get; set; }
    }
}
