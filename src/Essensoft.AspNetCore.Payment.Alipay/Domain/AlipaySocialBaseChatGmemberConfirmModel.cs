using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySocialBaseChatGmemberConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialBaseChatGmemberConfirmModel : AlipayObject
    {
        /// <summary>
        /// 业务类型，申请接入时和我们申请，用于统计和限流
        /// </summary>
        [JsonProperty("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 用户所在的群id
        /// </summary>
        [JsonProperty("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 要判断的用户id
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
