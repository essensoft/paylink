using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// EquityInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EquityInfo : AlipayObject
    {
        /// <summary>
        /// ‘杰克琼斯’
        /// </summary>
        [JsonProperty("description")]
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// ext_info
        /// </summary>
        [JsonProperty("ext_info")]
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// logo
        /// </summary>
        [JsonProperty("logo")]
        [XmlElement("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 天猫优惠券
        /// </summary>
        [JsonProperty("name")]
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// APPLIED：已申领；UNAPPLIED：未申领；DELETED：已过期
        /// </summary>
        [JsonProperty("status")]
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// url
        /// </summary>
        [JsonProperty("url")]
        [XmlElement("url")]
        public string Url { get; set; }

        /// <summary>
        /// 优惠价值
        /// </summary>
        [JsonProperty("value")]
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
