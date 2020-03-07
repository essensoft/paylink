using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OnlineInviteNewerDetailInfo Data Structure.
    /// </summary>
    public class OnlineInviteNewerDetailInfo : AlipayObject
    {
        /// <summary>
        /// 用户首登/回流时间
        /// </summary>
        [JsonPropertyName("fst_login_time")]
        public string FstLoginTime { get; set; }

        /// <summary>
        /// 绑定时间
        /// </summary>
        [JsonPropertyName("invite_time")]
        public string InviteTime { get; set; }

        /// <summary>
        /// 被邀请手机号
        /// </summary>
        [JsonPropertyName("invited_phone")]
        public string InvitedPhone { get; set; }

        /// <summary>
        /// 二级渠道
        /// </summary>
        [JsonPropertyName("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 一级渠道
        /// </summary>
        [JsonPropertyName("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 用户实名时间
        /// </summary>
        [JsonPropertyName("user_cert_time")]
        public string UserCertTime { get; set; }
    }
}
