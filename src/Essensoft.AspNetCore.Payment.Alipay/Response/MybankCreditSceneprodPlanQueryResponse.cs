using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// MybankCreditSceneprodPlanQueryResponse.
    /// </summary>
    public class MybankCreditSceneprodPlanQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 贷款方案内容
        /// </summary>
        [JsonPropertyName("loan_plan")]
        public string LoanPlan { get; set; }

        /// <summary>
        /// 是否离线准入，只有为true的时候loan_plan才会有数据
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; }

        /// <summary>
        /// 是否可重试
        /// </summary>
        [JsonPropertyName("retry")]
        public string Retry { get; set; }

        /// <summary>
        /// 签约时间
        /// </summary>
        [JsonPropertyName("sign_time")]
        public string SignTime { get; set; }

        /// <summary>
        /// 网商traceId，便于查询日志内容
        /// </summary>
        [JsonPropertyName("trace_id")]
        public string TraceId { get; set; }
    }
}
