using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// MybankCreditSceneprodPreadmitQueryResponse.
    /// </summary>
    public class MybankCreditSceneprodPreadmitQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 是否通过前准入校验，通过true, 拒绝false
        /// </summary>
        [JsonPropertyName("pre_admit_result")]
        public string PreAdmitResult { get; set; }

        /// <summary>
        /// 前准入拒绝原因错误码
        /// </summary>
        [JsonPropertyName("reject_code")]
        public string RejectCode { get; set; }

        /// <summary>
        /// 拒绝原因
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
