using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// IndividualInfo Data Structure.
    /// </summary>
    [Serializable]
    public class IndividualInfo : AlipayObject
    {
        /// <summary>
        /// 生日
        /// </summary>
        [JsonProperty("date_of_birth")]
        [XmlElement("date_of_birth")]
        public string DateOfBirth { get; set; }

        /// <summary>
        /// 证件号码
        /// </summary>
        [JsonProperty("id_number")]
        [XmlElement("id_number")]
        public string IdNumber { get; set; }

        /// <summary>
        /// 个人名字
        /// </summary>
        [JsonProperty("name")]
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 国籍
        /// </summary>
        [JsonProperty("nationality")]
        [XmlElement("nationality")]
        public string Nationality { get; set; }

        /// <summary>
        /// 个人居住地
        /// </summary>
        [JsonProperty("residential_address")]
        [XmlElement("residential_address")]
        public string ResidentialAddress { get; set; }

        /// <summary>
        /// 该个体的类型
        /// </summary>
        [JsonProperty("type")]
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
