using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CommentReplyOpenModel Data Structure.
    /// </summary>
    public class CommentReplyOpenModel : AlipayObject
    {
        /// <summary>
        /// 回复内容，最多500字，不区分中英文
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }

        /// <summary>
        /// 发表回复的操作员id
        /// </summary>
        [JsonPropertyName("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 回复发表时间
        /// </summary>
        [JsonPropertyName("reply_publish_time")]
        public string ReplyPublishTime { get; set; }
    }
}
