using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiContentContentstatusModifyResponse.
    /// </summary>
    public class KoubeiContentContentstatusModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 口碑内容的唯一id
        /// </summary>
        [JsonPropertyName("data")]
        public List<string> Data { get; set; }

        /// <summary>
        /// 全链路唯一id,由服务系统提供
        /// </summary>
        [JsonPropertyName("trace_id")]
        public string TraceId { get; set; }
    }
}
