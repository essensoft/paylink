using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// MybankCreditSceneprodDrawdownApplyResponse.
    /// </summary>
    public class MybankCreditSceneprodDrawdownApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 序号和支用号的对应关系
        /// </summary>
        [JsonPropertyName("drawdown_list")]
        public string DrawdownList { get; set; }

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
    }
}
