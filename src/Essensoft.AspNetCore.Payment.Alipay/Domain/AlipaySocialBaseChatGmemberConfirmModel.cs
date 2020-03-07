using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySocialBaseChatGmemberConfirmModel Data Structure.
    /// </summary>
    public class AlipaySocialBaseChatGmemberConfirmModel : AlipayObject
    {
        /// <summary>
        /// 业务类型，申请接入时和我们申请，用于统计和限流
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 用户所在的群id
        /// </summary>
        [JsonPropertyName("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 要判断的用户id
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
