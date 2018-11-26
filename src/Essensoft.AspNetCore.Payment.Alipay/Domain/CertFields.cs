using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CertFields Data Structure.
    /// </summary>
    [Serializable]
    public class CertFields : AlipayObject
    {
        /// <summary>
        /// 地址
        /// </summary>
        [JsonProperty("address")]
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 生日
        /// </summary>
        [JsonProperty("birth")]
        [XmlElement("birth")]
        public string Birth { get; set; }

        /// <summary>
        /// 证件号码
        /// </summary>
        [JsonProperty("certno")]
        [XmlElement("certno")]
        public string Certno { get; set; }

        /// <summary>
        /// 有效期
        /// </summary>
        [JsonProperty("expires")]
        [XmlElement("expires")]
        public string Expires { get; set; }

        /// <summary>
        /// 有效期结束日期
        /// </summary>
        [JsonProperty("expiresend")]
        [XmlElement("expiresend")]
        public string Expiresend { get; set; }

        /// <summary>
        /// 有效期开始时间
        /// </summary>
        [JsonProperty("expiresstart")]
        [XmlElement("expiresstart")]
        public string Expiresstart { get; set; }

        /// <summary>
        /// 签发机关
        /// </summary>
        [JsonProperty("issuingauthority")]
        [XmlElement("issuingauthority")]
        public string Issuingauthority { get; set; }

        /// <summary>
        /// 名字
        /// </summary>
        [JsonProperty("name")]
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 编号
        /// </summary>
        [JsonProperty("number")]
        [XmlElement("number")]
        public string Number { get; set; }

        /// <summary>
        /// 民族
        /// </summary>
        [JsonProperty("race")]
        [XmlElement("race")]
        public string Race { get; set; }

        /// <summary>
        /// 换证次数
        /// </summary>
        [JsonProperty("renewalnum")]
        [XmlElement("renewalnum")]
        public string Renewalnum { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [JsonProperty("sex")]
        [XmlElement("sex")]
        public string Sex { get; set; }
    }
}
