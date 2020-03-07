using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AntfortuneContentCommunityHoteventListQueryResponse.
    /// </summary>
    public class AntfortuneContentCommunityHoteventListQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 存储json序列化后的热门事件列表
        /// </summary>
        [JsonPropertyName("hot_event_product")]
        public string HotEventProduct { get; set; }

        /// <summary>
        /// 返回trace，方便排查问题
        /// </summary>
        [JsonPropertyName("trace_id")]
        public string TraceId { get; set; }
    }
}
