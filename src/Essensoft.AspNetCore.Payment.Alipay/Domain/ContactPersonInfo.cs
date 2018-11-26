using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ContactPersonInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ContactPersonInfo : AlipayObject
    {
        /// <summary>
        /// 联系人邮箱地址，入驻申请审核结果会发送至该邮箱
        /// </summary>
        [JsonProperty("contact_email")]
        [XmlElement("contact_email")]
        public string ContactEmail { get; set; }

        /// <summary>
        /// 联系人手机号，入驻申请结果会通过短信的形式发送至该手机号码
        /// </summary>
        [JsonProperty("contact_mobile")]
        [XmlElement("contact_mobile")]
        public string ContactMobile { get; set; }

        /// <summary>
        /// 企业联系人名称
        /// </summary>
        [JsonProperty("contact_name")]
        [XmlElement("contact_name")]
        public string ContactName { get; set; }

        /// <summary>
        /// 联系人类型，MERCHANT_CONTACT (普通联系人),DATA_RETURN (数据反馈联系人),PROT_CONTACT(客服人员),OBJECTION_HANDLE (异议处理联系人)，如不填默认为MERCHANT_CONTACT
        /// </summary>
        [JsonProperty("contact_type")]
        [XmlElement("contact_type")]
        public string ContactType { get; set; }
    }
}
