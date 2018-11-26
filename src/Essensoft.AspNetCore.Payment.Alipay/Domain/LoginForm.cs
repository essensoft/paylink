using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// LoginForm Data Structure.
    /// </summary>
    [Serializable]
    public class LoginForm : AlipayObject
    {
        /// <summary>
        /// 图片验证码
        /// </summary>
        [JsonProperty("captcha")]
        [XmlElement("captcha")]
        public string Captcha { get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        [JsonProperty("id_card_no")]
        [XmlElement("id_card_no")]
        public string IdCardNo { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [JsonProperty("name")]
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [JsonProperty("phone_no")]
        [XmlElement("phone_no")]
        public string PhoneNo { get; set; }

        /// <summary>
        /// 查询密码
        /// </summary>
        [JsonProperty("query_password")]
        [XmlElement("query_password")]
        public string QueryPassword { get; set; }

        /// <summary>
        /// 服务密码
        /// </summary>
        [JsonProperty("service_password")]
        [XmlElement("service_password")]
        public string ServicePassword { get; set; }

        /// <summary>
        /// 短信验证码
        /// </summary>
        [JsonProperty("sms_code")]
        [XmlElement("sms_code")]
        public string SmsCode { get; set; }

        /// <summary>
        /// 吉林电信短信验证码
        /// </summary>
        [JsonProperty("sms_code_jldx")]
        [XmlElement("sms_code_jldx")]
        public string SmsCodeJldx { get; set; }
    }
}
