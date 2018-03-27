using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Text Data Structure.
    /// </summary>
    public class Text : AlipayObject
    {
        /// <summary>
        /// 文本消息的内容
        /// </summary>
        [JsonProperty("content")]
        public string Content { get; set; }

        /// <summary>
        /// 文本消息的标题
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}
