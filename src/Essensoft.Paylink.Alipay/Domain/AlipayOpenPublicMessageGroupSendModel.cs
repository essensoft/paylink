using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicMessageGroupSendModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicMessageGroupSendModel : AlipayObject
    {
        /// <summary>
        /// 图文消息，当 msg_type为image-text，本参数必填。
        /// </summary>
        [JsonPropertyName("articles")]
        public List<Article> Articles { get; set; }

        /// <summary>
        /// 分组ID，通过<a href="https://opendocs.alipay.com/apis/api_6/alipay.open.public.group.create">alipay.open.public.group.create</a>（用户分组创建接口) 创建用户分组获取。
        /// </summary>
        [JsonPropertyName("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 纯图片消息，暂时不支持，包含url信息，当msg_type为image时，必须设置该值 ，图片尺寸建议为1080x750px，小于3M，图片支持jpg、png格式
        /// </summary>
        [JsonPropertyName("image")]
        public Image Image { get; set; }

        /// <summary>
        /// 消息类型。枚举支持： * text：表示文本消息； * image-text：表示图文消息。 
        /// </summary>
        [JsonPropertyName("msg_type")]
        public string MsgType { get; set; }

        /// <summary>
        /// 文本消息内容，当msg_type为text，本参数必填。
        /// </summary>
        [JsonPropertyName("text")]
        public Text Text { get; set; }
    }
}
