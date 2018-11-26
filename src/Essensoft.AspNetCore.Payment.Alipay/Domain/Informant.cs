using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Informant Data Structure.
    /// </summary>
    [Serializable]
    public class Informant : AlipayObject
    {
        /// <summary>
        /// 姓名，须与证件上名称一致
        /// </summary>
        [JsonProperty("cert_name")]
        [XmlElement("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// 报案人证件号码
        /// </summary>
        [JsonProperty("cert_no")]
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型，特殊可选，该字段需和证件号、名称同时有值或同时为空  枚举：  IDENTITY_CARD：身份证    备注：目前仅支持身份证类型
        /// </summary>
        [JsonProperty("cert_type")]
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [JsonProperty("mobile_no")]
        [XmlElement("mobile_no")]
        public string MobileNo { get; set; }
    }
}
