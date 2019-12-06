using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicMessageGroupSendModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicMessageGroupSendModel : AlipayObject
    {
        /// <summary>
        /// 图文消息，当msg_type为image-text，该值必须设置，图文消息中的图片建议尺寸 750 x 350px，小于3M，图片支持jpg、png格式
        /// </summary>
        [JsonPropertyName("articles")]
        public List<Article> Articles { get; set; }

        /// <summary>
        /// 用户分组ID
        /// </summary>
        [JsonPropertyName("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 纯图片消息，暂时不支持，包含url信息，当msg_type为image时，必须设置该值 ，图片尺寸建议为1080x750px，小于3M，图片支持jpg、png格式
        /// </summary>
        [JsonPropertyName("image")]
        public Image Image { get; set; }

        /// <summary>
        /// 消息类型，text表示文本消息，image-text表示图文消息
        /// </summary>
        [JsonPropertyName("msg_type")]
        public string MsgType { get; set; }

        /// <summary>
        /// 文本消息内容，当msg_type为text，必须设置该值，而且必须同时设置标题和内容字段
        /// </summary>
        [JsonPropertyName("text")]
        public Text Text { get; set; }
    }
}
