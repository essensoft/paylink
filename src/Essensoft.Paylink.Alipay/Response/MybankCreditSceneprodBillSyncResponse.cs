using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// MybankCreditSceneprodBillSyncResponse.
    /// </summary>
    public class MybankCreditSceneprodBillSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 网商traceId，便于查询日志内容
        /// </summary>
        [JsonPropertyName("trace_id")]
        public string TraceId { get; set; }
    }
}
