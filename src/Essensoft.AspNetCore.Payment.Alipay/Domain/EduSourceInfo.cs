using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// EduSourceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EduSourceInfo : AlipayObject
    {
        /// <summary>
        /// 供应商的LOGO
        /// </summary>
        [JsonProperty("logo")]
        [XmlElement("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 供应商电话
        /// </summary>
        [JsonProperty("mobile")]
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 供应商名字
        /// </summary>
        [JsonProperty("name")]
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
