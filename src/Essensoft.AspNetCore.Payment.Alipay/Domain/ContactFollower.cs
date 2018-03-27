using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ContactFollower Data Structure.
    /// </summary>
    public class ContactFollower : AlipayObject
    {
        /// <summary>
        /// 支付宝头像
        /// </summary>
        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        /// <summary>
        /// 默认头像
        /// </summary>
        [JsonProperty("default_avatar")]
        public string DefaultAvatar { get; set; }

        /// <summary>
        /// false
        /// </summary>
        [JsonProperty("each_record_flag")]
        public string EachRecordFlag { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
