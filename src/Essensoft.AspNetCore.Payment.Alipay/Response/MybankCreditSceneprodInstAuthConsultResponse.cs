using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// MybankCreditSceneprodInstAuthConsultResponse.
    /// </summary>
    public class MybankCreditSceneprodInstAuthConsultResponse : AlipayResponse
    {
        /// <summary>
        /// 是否准入
        /// </summary>
        [JsonPropertyName("auth")]
        public string Auth { get; set; }

        /// <summary>
        /// 咨询内容返回的结果
        /// </summary>
        [JsonPropertyName("consult_result")]
        public string ConsultResult { get; set; }

        /// <summary>
        /// 网商traceId，便于查询日志内容
        /// </summary>
        [JsonPropertyName("trace_id")]
        public string TraceId { get; set; }
    }
}
