using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ContactModel Data Structure.
    /// </summary>
    [Serializable]
    public class ContactModel : AlipayObject
    {
        /// <summary>
        /// 联系人邮箱
        /// </summary>
        [JsonProperty("contact_email")]
        [XmlElement("contact_email")]
        public string ContactEmail { get; set; }

        /// <summary>
        /// 联系人手机号码
        /// </summary>
        [JsonProperty("contact_mobile")]
        [XmlElement("contact_mobile")]
        public string ContactMobile { get; set; }

        /// <summary>
        /// 联系人名称
        /// </summary>
        [JsonProperty("contact_name")]
        [XmlElement("contact_name")]
        public string ContactName { get; set; }
    }
}
