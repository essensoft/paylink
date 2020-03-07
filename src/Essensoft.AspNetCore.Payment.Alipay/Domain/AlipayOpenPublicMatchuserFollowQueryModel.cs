using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicMatchuserFollowQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicMatchuserFollowQueryModel : AlipayObject
    {
        /// <summary>
        /// 身份证号码
        /// </summary>
        [JsonPropertyName("identity_card")]
        public string IdentityCard { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        [JsonPropertyName("mobile_no")]
        public string MobileNo { get; set; }

        /// <summary>
        /// 支付宝用户id，2088开头的16位长度字符串
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
