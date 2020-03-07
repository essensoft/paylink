using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MemberInfo Data Structure.
    /// </summary>
    public class MemberInfo : AlipayObject
    {
        /// <summary>
        /// 群成员性别，m表示男，f表示女
        /// </summary>
        [JsonPropertyName("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// 群内昵称
        /// </summary>
        [JsonPropertyName("group_nick_name")]
        public string GroupNickName { get; set; }

        /// <summary>
        /// 邀请人id
        /// </summary>
        [JsonPropertyName("inviter_uid")]
        public string InviterUid { get; set; }

        /// <summary>
        /// 群成员头像url
        /// </summary>
        [JsonPropertyName("member_img")]
        public string MemberImg { get; set; }

        /// <summary>
        /// 用户昵称
        /// </summary>
        [JsonPropertyName("nick_name")]
        public string NickName { get; set; }

        /// <summary>
        /// 群成员用户id
        /// </summary>
        [JsonPropertyName("uid")]
        public string Uid { get; set; }
    }
}
