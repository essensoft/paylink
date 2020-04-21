using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// GroupMemberInfo Data Structure.
    /// </summary>
    public class GroupMemberInfo : AlipayObject
    {
        /// <summary>
        /// 用户在这个群里的昵称
        /// </summary>
        [JsonPropertyName("group_nickname")]
        public string GroupNickname { get; set; }

        /// <summary>
        /// 个人昵称
        /// </summary>
        [JsonPropertyName("nickname")]
        public string Nickname { get; set; }

        /// <summary>
        /// 用户的uid
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
