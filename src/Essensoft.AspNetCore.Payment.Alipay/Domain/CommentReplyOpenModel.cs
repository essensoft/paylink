using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CommentReplyOpenModel Data Structure.
    /// </summary>
    [Serializable]
    public class CommentReplyOpenModel : AlipayObject
    {
        /// <summary>
        /// 回复内容，最多500字，不区分中英文
        /// </summary>
        [JsonProperty("content")]
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 发表回复的操作员id
        /// </summary>
        [JsonProperty("operator_id")]
        [XmlElement("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 回复发表时间
        /// </summary>
        [JsonProperty("reply_publish_time")]
        [XmlElement("reply_publish_time")]
        public string ReplyPublishTime { get; set; }
    }
}
