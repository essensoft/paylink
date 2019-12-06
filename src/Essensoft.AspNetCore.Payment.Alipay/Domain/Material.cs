using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Material Data Structure.
    /// </summary>
    public class Material : AlipayObject
    {
        /// <summary>
        /// 图文消息子消息项集合，单条消息最多6个子项，否则会发送失败
        /// </summary>
        [JsonPropertyName("articles")]
        public List<Article> Articles { get; set; }

        /// <summary>
        /// 消息类型，text：文本类型，image-text：图文类型。当消息类型为text时，text参数必传，当消息类型为image-text时，articles参数必传
        /// </summary>
        [JsonPropertyName("msg_type")]
        public string MsgType { get; set; }

        /// <summary>
        /// 文本消息内容
        /// </summary>
        [JsonPropertyName("text")]
        public Text Text { get; set; }
    }
}
