using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMemberDataOutuserinfoModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMemberDataOutuserinfoModifyModel : AlipayObject
    {
        /// <summary>
        /// http://avatar_url.com
        /// </summary>
        [JsonProperty("avatar_url")]
        public string AvatarUrl { get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// 国家
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// 1 男，2 女
        /// </summary>
        [JsonProperty("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// 微信昵称
        /// </summary>
        [JsonProperty("nick_name")]
        public string NickName { get; set; }

        /// <summary>
        /// 支付宝用户Id，即匿名用户Id
        /// </summary>
        [JsonProperty("out_user_id")]
        public string OutUserId { get; set; }

        /// <summary>
        /// 用户手机号
        /// </summary>
        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// 省份
        /// </summary>
        [JsonProperty("province")]
        public string Province { get; set; }
    }
}
