using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingIbsInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingIbsInfo : AlipayObject
    {
        /// <summary>
        /// 精度
        /// </summary>
        [JsonProperty("accuracy")]
        [XmlElement("accuracy")]
        public string Accuracy { get; set; }

        /// <summary>
        /// 海拔
        /// </summary>
        [JsonProperty("altitude")]
        [XmlElement("altitude")]
        public string Altitude { get; set; }

        /// <summary>
        /// 维度
        /// </summary>
        [JsonProperty("latitude")]
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [JsonProperty("longitude")]
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 时间ms
        /// </summary>
        [JsonProperty("time")]
        [XmlElement("time")]
        public string Time { get; set; }
    }
}
