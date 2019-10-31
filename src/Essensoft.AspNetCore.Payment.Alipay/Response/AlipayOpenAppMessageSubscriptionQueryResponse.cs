using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenAppMessageSubscriptionQueryResponse.
    /// </summary>
    public class AlipayOpenAppMessageSubscriptionQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 消息接入方式，例如HTTP
        /// </summary>
        [JsonProperty("comm_type")]
        public string CommType { get; set; }

        /// <summary>
        /// 消息标签
        /// </summary>
        [JsonProperty("tag")]
        public string Tag { get; set; }

        /// <summary>
        /// 消息主题名称
        /// </summary>
        [JsonProperty("topic")]
        public string Topic { get; set; }
    }
}
