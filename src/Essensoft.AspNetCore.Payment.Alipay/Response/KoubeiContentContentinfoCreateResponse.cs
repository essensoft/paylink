using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiContentContentinfoCreateResponse.
    /// </summary>
    public class KoubeiContentContentinfoCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 内容id,由内容创建成功后返回。存在返回结果实体类中的data字段内。
        /// </summary>
        [JsonPropertyName("data")]
        public string Data { get; set; }

        /// <summary>
        /// traceId,全链路Id.
        /// </summary>
        [JsonPropertyName("trace_id")]
        public string TraceId { get; set; }
    }
}
