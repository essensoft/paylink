using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PintuanUserInfo Data Structure.
    /// </summary>
    public class PintuanUserInfo : AlipayObject
    {
        /// <summary>
        /// 头像地址
        /// </summary>
        [JsonPropertyName("avatar_url")]
        public string AvatarUrl { get; set; }

        /// <summary>
        /// havanaId
        /// </summary>
        [JsonPropertyName("havana_id")]
        public string HavanaId { get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        [JsonPropertyName("nick_name")]
        public string NickName { get; set; }
    }
}
