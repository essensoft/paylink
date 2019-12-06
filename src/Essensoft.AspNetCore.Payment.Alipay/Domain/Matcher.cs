using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Matcher Data Structure.
    /// </summary>
    public class Matcher : AlipayObject
    {
        /// <summary>
        /// 身份证号码，与user_id、mobile_no不能同时为空
        /// </summary>
        [JsonPropertyName("identity_card")]
        public string IdentityCard { get; set; }

        /// <summary>
        /// 手机号码，与user_id、identity_card不能同时为空
        /// </summary>
        [JsonPropertyName("mobile_no")]
        public string MobileNo { get; set; }

        /// <summary>
        /// 支付宝用户id，2088开头16位长度的字符串，与mobile_no、identity_card不能同时为空
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
