using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Response
{
    /// <summary>
    /// AlipayOpenPublicTopicCreateResponse.
    /// </summary>
    public class AlipayOpenPublicTopicCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 营销位id
        /// </summary>
        [JsonProperty("topic_id")]
        public string TopicId { get; set; }
    }
}
