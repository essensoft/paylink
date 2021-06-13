using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ChatMessage Data Structure.
    /// </summary>
    public class ChatMessage : AlipayObject
    {
        /// <summary>
        /// 消息内容
        /// </summary>
        [JsonPropertyName("message_content")]
        public string MessageContent { get; set; }

        /// <summary>
        /// 消息内容类型,默认TEXT,包括: TEXT(文本消息),IMAGE(图片消息),FILE(文件消息)
        /// </summary>
        [JsonPropertyName("message_type")]
        public string MessageType { get; set; }

        /// <summary>
        /// 消息发送时间，按照ISO8601标准表示，比如：2018-12-24T15:38:17.824+08:00
        /// </summary>
        [JsonPropertyName("send_time")]
        public string SendTime { get; set; }

        /// <summary>
        /// 发送者名称
        /// </summary>
        [JsonPropertyName("user_name")]
        public string UserName { get; set; }

        /// <summary>
        /// 发送者类型: VISITOR(访客) ,AGENT(在线客服) ,SYSTEM(系统)
        /// </summary>
        [JsonPropertyName("user_type")]
        public string UserType { get; set; }
    }
}
