using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// EduWorkAddress Data Structure.
    /// </summary>
    [Serializable]
    public class EduWorkAddress : AlipayObject
    {
        /// <summary>
        /// 地址
        /// </summary>
        [JsonProperty("address")]
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        [JsonProperty("city")]
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 区
        /// </summary>
        [JsonProperty("district_name")]
        [XmlElement("district_name")]
        public string DistrictName { get; set; }

        /// <summary>
        /// 北京市
        /// </summary>
        [JsonProperty("province")]
        [XmlElement("province")]
        public string Province { get; set; }

        /// <summary>
        /// 街道
        /// </summary>
        [JsonProperty("street_name")]
        [XmlElement("street_name")]
        public string StreetName { get; set; }
    }
}
