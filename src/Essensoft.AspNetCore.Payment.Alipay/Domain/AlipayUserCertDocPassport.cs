using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserCertDocPassport Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserCertDocPassport : AlipayObject
    {
        /// <summary>
        /// base64编码后的主页照片
        /// </summary>
        [JsonProperty("encoded_img")]
        [XmlElement("encoded_img")]
        public string EncodedImg { get; set; }

        /// <summary>
        /// 失效日期
        /// </summary>
        [JsonProperty("expire_date")]
        [XmlElement("expire_date")]
        public string ExpireDate { get; set; }

        /// <summary>
        /// 姓氏，拼音
        /// </summary>
        [JsonProperty("family_name")]
        [XmlElement("family_name")]
        public string FamilyName { get; set; }

        /// <summary>
        /// 名，拼音
        /// </summary>
        [JsonProperty("given_name")]
        [XmlElement("given_name")]
        public string GivenName { get; set; }

        /// <summary>
        /// 证件号码
        /// </summary>
        [JsonProperty("number")]
        [XmlElement("number")]
        public string Number { get; set; }
    }
}
