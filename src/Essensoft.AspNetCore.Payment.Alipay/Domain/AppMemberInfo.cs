using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AppMemberInfo Data Structure.
    /// </summary>
    public class AppMemberInfo : AlipayObject
    {
        /// <summary>
        /// 邀请时间
        /// </summary>
        [JsonPropertyName("gmt_invite")]
        public string GmtInvite { get; set; }

        /// <summary>
        /// 加入时间
        /// </summary>
        [JsonPropertyName("gmt_join")]
        public string GmtJoin { get; set; }

        /// <summary>
        /// 支付宝登录账号
        /// </summary>
        [JsonPropertyName("logon_id")]
        public string LogonId { get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        [JsonPropertyName("nick_name")]
        public string NickName { get; set; }

        /// <summary>
        /// 头像地址
        /// </summary>
        [JsonPropertyName("portrait")]
        public string Portrait { get; set; }

        /// <summary>
        /// 角色类型
        /// </summary>
        [JsonPropertyName("role")]
        public string Role { get; set; }

        /// <summary>
        /// 成员的状态，VALID-有效，UNCONFIRMED-未确认，TIMEOUT-已经失效，REFUSED-用户拒绝
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
