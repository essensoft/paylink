using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MemberShip Data Structure.
    /// </summary>
    [Serializable]
    public class MemberShip : AlipayObject
    {
        /// <summary>
        /// 银行卡号
        /// </summary>
        [JsonProperty("bank_card_no")]
        [XmlElement("bank_card_no")]
        public string BankCardNo { get; set; }

        /// <summary>
        /// 会员二代身份证号码
        /// </summary>
        [JsonProperty("cert_no")]
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 邮箱号码
        /// </summary>
        [JsonProperty("email")]
        [XmlElement("email")]
        public string Email { get; set; }

        /// <summary>
        /// MAC地址
        /// </summary>
        [JsonProperty("mac")]
        [XmlElement("mac")]
        public string Mac { get; set; }

        /// <summary>
        /// 11位手机号码
        /// </summary>
        [JsonProperty("mobile_phone_no")]
        [XmlElement("mobile_phone_no")]
        public string MobilePhoneNo { get; set; }
    }
}
