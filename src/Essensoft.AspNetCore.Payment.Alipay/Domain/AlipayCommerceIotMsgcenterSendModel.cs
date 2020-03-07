using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceIotMsgcenterSendModel Data Structure.
    /// </summary>
    public class AlipayCommerceIotMsgcenterSendModel : AlipayObject
    {
        /// <summary>
        /// 消息内容
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }

        /// <summary>
        /// 消息发送的时间，毫秒级的时间戳
        /// </summary>
        [JsonPropertyName("datetime")]
        public long Datetime { get; set; }

        /// <summary>
        /// 扩展参数，json序列化后的字符串
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 消息是否支持跳转链接
        /// </summary>
        [JsonPropertyName("is_support_link")]
        public bool IsSupportLink { get; set; }

        /// <summary>
        /// 消息跳转链接
        /// </summary>
        [JsonPropertyName("link")]
        public string Link { get; set; }

        /// <summary>
        /// 消息标题
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// 消息类型, 0：普通消息、1：发送push的消息
        /// </summary>
        [JsonPropertyName("type")]
        public long Type { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
