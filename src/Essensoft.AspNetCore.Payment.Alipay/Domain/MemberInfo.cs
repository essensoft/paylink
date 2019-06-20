using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MemberInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MemberInfo : AlipayObject
    {
        /// <summary>
        /// 群成员性别，m表示男，f表示女
        /// </summary>
        [JsonProperty("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// 群内昵称
        /// </summary>
        [JsonProperty("group_nick_name")]
        public string GroupNickName { get; set; }

        /// <summary>
        /// 邀请人id
        /// </summary>
        [JsonProperty("inviter_uid")]
        public string InviterUid { get; set; }

        /// <summary>
        /// 群成员头像url
        /// </summary>
        [JsonProperty("member_img")]
        public string MemberImg { get; set; }

        /// <summary>
        /// 用户昵称
        /// </summary>
        [JsonProperty("nick_name")]
        public string NickName { get; set; }

        /// <summary>
        /// 群成员用户id
        /// </summary>
        [JsonProperty("uid")]
        public string Uid { get; set; }
    }
}
