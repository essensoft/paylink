using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserAuthZhimaorgIdentityApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAuthZhimaorgIdentityApplyModel : AlipayObject
    {
        /// <summary>
        /// 营业执照号码
        /// </summary>
        [JsonProperty("cert_no")]
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// NATIONAL_LEGAL:营业执照号码  NATIONAL_LEGAL_MERGE:三证合一号码
        /// </summary>
        [JsonProperty("cert_type")]
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        [JsonProperty("name")]
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
