using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InsCertificate Data Structure.
    /// </summary>
    [Serializable]
    public class InsCertificate : AlipayObject
    {
        /// <summary>
        /// 发奖凭证ID
        /// </summary>
        [JsonProperty("certificate_id")]
        [XmlElement("certificate_id")]
        public string CertificateId { get; set; }

        /// <summary>
        /// 发奖凭证类型;GIFT_INSURANCE:赠险
        /// </summary>
        [JsonProperty("certificate_type")]
        [XmlElement("certificate_type")]
        public string CertificateType { get; set; }

        /// <summary>
        /// 发奖凭证值
        /// </summary>
        [JsonProperty("certificate_value")]
        [XmlElement("certificate_value")]
        public string CertificateValue { get; set; }
    }
}
