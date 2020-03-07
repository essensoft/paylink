using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiContentContentinfoDeleteResponse.
    /// </summary>
    public class KoubeiContentContentinfoDeleteResponse : AlipayResponse
    {
        /// <summary>
        /// 口碑内容的唯一id
        /// </summary>
        [JsonPropertyName("data")]
        public string Data { get; set; }

        /// <summary>
        /// 全链路Id
        /// </summary>
        [JsonPropertyName("trace_id")]
        public string TraceId { get; set; }
    }
}
