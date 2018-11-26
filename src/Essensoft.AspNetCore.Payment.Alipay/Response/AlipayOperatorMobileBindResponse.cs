using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOperatorMobileBindResponse.
    /// </summary>
    public class AlipayOperatorMobileBindResponse : AlipayResponse
    {
        /// <summary>
        /// 用户签约的支付宝账号对应的支付宝唯一用户号。  以2088开头的16位纯数字组成。
        /// </summary>
        [JsonProperty("alipay_user_id")]
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 身份证号：显示前1位+*（实际位数）+后1位，如：5****************9
        /// </summary>
        [JsonProperty("certificate")]
        [XmlElement("certificate")]
        public string Certificate { get; set; }

        /// <summary>
        /// 用户手机号码
        /// </summary>
        [JsonProperty("mobile_no")]
        [XmlElement("mobile_no")]
        public string MobileNo { get; set; }

        /// <summary>
        /// 绑定状态：  &#61548; S表示绑定成功  &#61548; F表示绑定失败
        /// </summary>
        [JsonProperty("status")]
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 显示除姓名第一个字以外的其它部分
        /// </summary>
        [JsonProperty("user_name")]
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
