using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PintuanUserInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PintuanUserInfo : AlipayObject
    {
        /// <summary>
        /// 头像地址
        /// </summary>
        [JsonProperty("avatar_url")]
        public string AvatarUrl { get; set; }

        /// <summary>
        /// havanaId
        /// </summary>
        [JsonProperty("havana_id")]
        public string HavanaId { get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        [JsonProperty("nick_name")]
        public string NickName { get; set; }
    }
}
