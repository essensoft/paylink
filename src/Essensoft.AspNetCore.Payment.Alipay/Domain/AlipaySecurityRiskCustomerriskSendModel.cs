using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityRiskCustomerriskSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityRiskCustomerriskSendModel : AlipayObject
    {
        /// <summary>
        /// 身份证号码
        /// </summary>
        [JsonProperty("cert_no")]
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [JsonProperty("mobile")]
        [XmlElement("mobile")]
        public string Mobile { get; set; }
    }
}
