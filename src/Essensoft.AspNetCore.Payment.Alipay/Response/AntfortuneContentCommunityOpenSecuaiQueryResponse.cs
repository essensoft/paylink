using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AntfortuneContentCommunityOpenSecuaiQueryResponse.
    /// </summary>
    public class AntfortuneContentCommunityOpenSecuaiQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 存储json序列化后的业务结果
        /// </summary>
        [JsonPropertyName("secuai_open_result")]
        public string SecuaiOpenResult { get; set; }

        /// <summary>
        /// trace信息，方便排查问题
        /// </summary>
        [JsonPropertyName("trace_id")]
        public string TraceId { get; set; }
    }
}
