using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// MybankCreditSceneprodLoanModifyResponse.
    /// </summary>
    public class MybankCreditSceneprodLoanModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 在特定状态修改完毕后的返回内容，里面包含合作机构推进流程的信息。
        /// </summary>
        [JsonPropertyName("result_content")]
        public string ResultContent { get; set; }

        /// <summary>
        /// 是否重试
        /// </summary>
        [JsonPropertyName("retry")]
        public string Retry { get; set; }

        /// <summary>
        /// 网商traceId，便于查询日志内容
        /// </summary>
        [JsonPropertyName("trace_id")]
        public string TraceId { get; set; }
    }
}
