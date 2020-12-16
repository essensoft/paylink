using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PublicMessageBody Data Structure.
    /// </summary>
    public class PublicMessageBody : AlipayObject
    {
        /// <summary>
        /// 图文消息，当msg_type为image-text，该值必须设置，图文消息中的图片建议尺寸 750 x 350px，小于3M，图片支持jpg、png格式
        /// </summary>
        [JsonPropertyName("articles")]
        public List<Article> Articles { get; set; }

        /// <summary>
        /// 图文类型，目前只支持image-text 和 text
        /// </summary>
        [JsonPropertyName("msg_type")]
        public string MsgType { get; set; }

        /// <summary>
        /// 纯文字消息内容
        /// </summary>
        [JsonPropertyName("text")]
        public TextContent Text { get; set; }
    }
}
