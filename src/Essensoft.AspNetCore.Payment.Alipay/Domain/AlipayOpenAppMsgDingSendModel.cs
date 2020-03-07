using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppMsgDingSendModel Data Structure.
    /// </summary>
    public class AlipayOpenAppMsgDingSendModel : AlipayObject
    {
        /// <summary>
        /// 钉钉企业应用ID
        /// </summary>
        [JsonPropertyName("agent_id")]
        public string AgentId { get; set; }

        /// <summary>
        /// 消息类型为text时表示消息内容、消息类型为link时表示消息描述
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }

        /// <summary>
        /// 消息类型为link时的消息点击链接地址
        /// </summary>
        [JsonPropertyName("goto_url")]
        public string GotoUrl { get; set; }

        /// <summary>
        /// 消息类型为link时的图片地址，支持jpg格式图片，大小不超过1MB
        /// </summary>
        [JsonPropertyName("image_url")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// 消息类型，文本为text；链接为link
        /// </summary>
        [JsonPropertyName("msg_type")]
        public string MsgType { get; set; }

        /// <summary>
        /// 接收者，个人为single；部门为department
        /// </summary>
        [JsonPropertyName("receiver")]
        public string Receiver { get; set; }

        /// <summary>
        /// 消息类型为link时的消息标题
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// 用户UID列表
        /// </summary>
        [JsonPropertyName("user_ids")]
        public List<string> UserIds { get; set; }
    }
}
