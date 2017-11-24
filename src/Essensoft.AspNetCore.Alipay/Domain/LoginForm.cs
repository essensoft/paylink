using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// LoginForm Data Structure.
    /// </summary>
    public class LoginForm : AlipayObject
    {
        /// <summary>
        /// 图片验证码
        /// </summary>
        [JsonProperty("captcha")]
        public string Captcha { get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        [JsonProperty("id_card_no")]
        public string IdCardNo { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [JsonProperty("phone_no")]
        public string PhoneNo { get; set; }

        /// <summary>
        /// 查询密码
        /// </summary>
        [JsonProperty("query_password")]
        public string QueryPassword { get; set; }

        /// <summary>
        /// 服务密码
        /// </summary>
        [JsonProperty("service_password")]
        public string ServicePassword { get; set; }

        /// <summary>
        /// 短信验证码
        /// </summary>
        [JsonProperty("sms_code")]
        public string SmsCode { get; set; }

        /// <summary>
        /// 吉林电信短信验证码
        /// </summary>
        [JsonProperty("sms_code_jldx")]
        public string SmsCodeJldx { get; set; }
    }
}
