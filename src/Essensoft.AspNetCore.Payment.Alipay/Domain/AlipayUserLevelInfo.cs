using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserLevelInfo Data Structure.
    /// </summary>
    public class AlipayUserLevelInfo : AlipayObject
    {
        /// <summary>
        /// 支付宝用户登陆账号；邮箱优先，手机号次之
        /// </summary>
        [JsonPropertyName("login_id")]
        public string LoginId { get; set; }

        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户等级：可选5、4、3、2、1、0；等级5最高，1最低，0标示无法判断
        /// </summary>
        [JsonPropertyName("user_level")]
        public string UserLevel { get; set; }
    }
}
