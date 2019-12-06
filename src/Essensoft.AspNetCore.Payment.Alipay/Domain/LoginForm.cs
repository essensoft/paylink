using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// LoginForm Data Structure.
    /// </summary>
    public class LoginForm : AlipayObject
    {
        /// <summary>
        /// 图片验证码
        /// </summary>
        [JsonPropertyName("captcha")]
        public string Captcha { get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        [JsonPropertyName("id_card_no")]
        public string IdCardNo { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [JsonPropertyName("phone_no")]
        public string PhoneNo { get; set; }

        /// <summary>
        /// 查询密码
        /// </summary>
        [JsonPropertyName("query_password")]
        public string QueryPassword { get; set; }

        /// <summary>
        /// 服务密码
        /// </summary>
        [JsonPropertyName("service_password")]
        public string ServicePassword { get; set; }

        /// <summary>
        /// 短信验证码
        /// </summary>
        [JsonPropertyName("sms_code")]
        public string SmsCode { get; set; }

        /// <summary>
        /// 吉林电信短信验证码
        /// </summary>
        [JsonPropertyName("sms_code_jldx")]
        public string SmsCodeJldx { get; set; }
    }
}
