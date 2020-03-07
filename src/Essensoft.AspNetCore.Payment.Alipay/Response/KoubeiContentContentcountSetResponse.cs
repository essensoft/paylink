using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiContentContentcountSetResponse.
    /// </summary>
    public class KoubeiContentContentcountSetResponse : AlipayResponse
    {
        /// <summary>
        /// 口碑内容的唯一id
        /// </summary>
        [JsonPropertyName("content_id")]
        public string ContentId { get; set; }

        /// <summary>
        /// 全链路唯一id,由服务系统提供
        /// </summary>
        [JsonPropertyName("trace_id")]
        public string TraceId { get; set; }
    }
}
