using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SocialInfoView Data Structure.
    /// </summary>
    public class SocialInfoView : AlipayObject
    {
        /// <summary>
        /// 用户头像链接，如果用户没有设置头像，则返回空
        /// </summary>
        [JsonPropertyName("avatar")]
        public string Avatar { get; set; }

        /// <summary>
        /// 用户昵称，如果用户没有设置昵称，则返回空
        /// </summary>
        [JsonPropertyName("nick")]
        public string Nick { get; set; }

        /// <summary>
        /// 支付宝userId
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
