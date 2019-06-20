using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppMsgDingSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppMsgDingSendModel : AlipayObject
    {
        /// <summary>
        /// 钉钉企业应用ID
        /// </summary>
        [JsonProperty("agent_id")]
        public string AgentId { get; set; }

        /// <summary>
        /// 消息类型为text时表示消息内容、消息类型为link时表示消息描述
        /// </summary>
        [JsonProperty("content")]
        public string Content { get; set; }

        /// <summary>
        /// 消息类型为link时的消息点击链接地址
        /// </summary>
        [JsonProperty("goto_url")]
        public string GotoUrl { get; set; }

        /// <summary>
        /// 消息类型为link时的图片地址，支持jpg格式图片，大小不超过1MB
        /// </summary>
        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// 消息类型，文本为text；链接为link
        /// </summary>
        [JsonProperty("msg_type")]
        public string MsgType { get; set; }

        /// <summary>
        /// 接收者，个人为single；部门为department
        /// </summary>
        [JsonProperty("receiver")]
        public string Receiver { get; set; }

        /// <summary>
        /// 消息类型为link时的消息标题
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// 用户UID列表
        /// </summary>
        [JsonProperty("user_ids")]
        public List<string> UserIds { get; set; }
    }
}
