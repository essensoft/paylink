using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TextContent Data Structure.
    /// </summary>
    public class TextContent : AlipayObject
    {
        /// <summary>
        /// 文本消息的内容
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }

        /// <summary>
        /// 文本消息的标题
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
