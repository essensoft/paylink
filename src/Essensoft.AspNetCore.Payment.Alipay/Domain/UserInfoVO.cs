using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// UserInfoVO Data Structure.
    /// </summary>
    public class UserInfoVO : AlipayObject
    {
        /// <summary>
        /// 孩子生日
        /// </summary>
        [JsonPropertyName("birthday")]
        public string Birthday { get; set; }

        /// <summary>
        /// 头像路径，如果无头像需要有兜底图
        /// </summary>
        [JsonPropertyName("head_url")]
        public string HeadUrl { get; set; }

        /// <summary>
        /// 孩子昵称
        /// </summary>
        [JsonPropertyName("nick_name")]
        public string NickName { get; set; }

        /// <summary>
        /// 孩子UID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
