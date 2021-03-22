using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// MybankCreditSceneprodDiscountplanQueryResponse.
    /// </summary>
    public class MybankCreditSceneprodDiscountplanQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 咨询结果，包含贴息方案的相关信息。
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
