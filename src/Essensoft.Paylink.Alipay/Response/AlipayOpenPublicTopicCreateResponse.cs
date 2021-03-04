using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenPublicTopicCreateResponse.
    /// </summary>
    public class AlipayOpenPublicTopicCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 营销位id
        /// </summary>
        [JsonPropertyName("topic_id")]
        public string TopicId { get; set; }
    }
}
