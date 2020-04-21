using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// MybankCreditSceneprodVidGetResponse.
    /// </summary>
    public class MybankCreditSceneprodVidGetResponse : AlipayResponse
    {
        /// <summary>
        /// 是否可重试
        /// </summary>
        [JsonPropertyName("retry")]
        public string Retry { get; set; }

        /// <summary>
        /// 网商traceId，便于查询日志内容
        /// </summary>
        [JsonPropertyName("trace_id")]
        public string TraceId { get; set; }

        /// <summary>
        /// 支付宝核身VID
        /// </summary>
        [JsonPropertyName("verify_id")]
        public string VerifyId { get; set; }
    }
}
