using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicMessageCustomSendModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicMessageCustomSendModel : AlipayObject
    {
        /// <summary>
        /// 图文消息，当msg_type为image-text时，必须存在相对应的值
        /// </summary>
        [JsonPropertyName("articles")]
        public List<Article> Articles { get; set; }

        /// <summary>
        /// 是否是聊天消息。支持值：0，1，当值为0时，代表是非聊天消息，消息显示在生活号主页，当值为1时，代表是聊天消息，消息显示在咨询反馈列表页。默认值为0
        /// </summary>
        [JsonPropertyName("chat")]
        public string Chat { get; set; }

        /// <summary>
        /// 触发消息的事件类型，默认为空。代表商户未改造。如果是follow，代表关注消息。click代表菜单点击，enter_ppchat代表进入事件；请注意事件类型的大小写
        /// </summary>
        [JsonPropertyName("event_type")]
        public string EventType { get; set; }

        /// <summary>
        /// 消息类型，text：文本消息，image-text：图文消息
        /// </summary>
        [JsonPropertyName("msg_type")]
        public string MsgType { get; set; }

        /// <summary>
        /// 当msg_type为text时，必须设置相对应的值
        /// </summary>
        [JsonPropertyName("text")]
        public Text Text { get; set; }

        /// <summary>
        /// 消息接收用户的userid
        /// </summary>
        [JsonPropertyName("to_user_id")]
        public string ToUserId { get; set; }
    }
}
