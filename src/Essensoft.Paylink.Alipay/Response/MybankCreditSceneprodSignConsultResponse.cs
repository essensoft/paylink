using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// MybankCreditSceneprodSignConsultResponse.
    /// </summary>
    public class MybankCreditSceneprodSignConsultResponse : AlipayResponse
    {
        /// <summary>
        /// 是否允许签约
        /// </summary>
        [JsonPropertyName("approved")]
        public string Approved { get; set; }

        /// <summary>
        /// 拒绝原因，当approved为false的时候透出
        /// </summary>
        [JsonPropertyName("reject_reason")]
        public string RejectReason { get; set; }

        /// <summary>
        /// 网商traceId，便于查询日志内容
        /// </summary>
        [JsonPropertyName("trace_id")]
        public string TraceId { get; set; }
    }
}
