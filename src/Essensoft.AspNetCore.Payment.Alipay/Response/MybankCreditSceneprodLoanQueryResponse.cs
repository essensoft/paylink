using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// MybankCreditSceneprodLoanQueryResponse.
    /// </summary>
    public class MybankCreditSceneprodLoanQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 对于订单信息需要说明的内容
        /// </summary>
        [JsonPropertyName("desc_msg")]
        public string DescMsg { get; set; }

        /// <summary>
        /// 返回当前订单的信息
        /// </summary>
        [JsonPropertyName("info")]
        public string Info { get; set; }

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
