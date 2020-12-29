using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DefiCustUserDTO Data Structure.
    /// </summary>
    public class DefiCustUserDTO : AlipayObject
    {
        /// <summary>
        /// 管理员名称
        /// </summary>
        [JsonPropertyName("admin_name")]
        public string AdminName { get; set; }

        /// <summary>
        /// 会员信息
        /// </summary>
        [JsonPropertyName("member_info")]
        public DefiCustMemberDTO MemberInfo { get; set; }

        /// <summary>
        /// 角色
        /// </summary>
        [JsonPropertyName("role_types")]
        public List<string> RoleTypes { get; set; }

        /// <summary>
        /// ACTIVE("ACTIVE", "激活状态"), FROZEN("FROZEN", "冻结状态"), DISABLED("DISABLED", "禁用状态"),;
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 用户邮箱
        /// </summary>
        [JsonPropertyName("user_email")]
        public string UserEmail { get; set; }

        /// <summary>
        /// user id
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户手机
        /// </summary>
        [JsonPropertyName("user_mobile")]
        public string UserMobile { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [JsonPropertyName("user_name")]
        public string UserName { get; set; }
    }
}
