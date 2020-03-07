using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PayForPrivilegeUserRelation Data Structure.
    /// </summary>
    public class PayForPrivilegeUserRelation : AlipayObject
    {
        /// <summary>
        /// 关系建立时间
        /// </summary>
        [JsonPropertyName("join_time")]
        public string JoinTime { get; set; }

        /// <summary>
        /// 关系解除时间，如果当前关系已解除该字段一定存在
        /// </summary>
        [JsonPropertyName("leave_time")]
        public string LeaveTime { get; set; }

        /// <summary>
        /// 充享惠业务用户与商户关系ID
        /// </summary>
        [JsonPropertyName("member_id")]
        public string MemberId { get; set; }

        /// <summary>
        /// 会员所属商户ID
        /// </summary>
        [JsonPropertyName("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 当前关系状态，VALID(有效), DELETED(删除)
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
