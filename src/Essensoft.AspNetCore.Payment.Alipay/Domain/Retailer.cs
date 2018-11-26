using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Retailer Data Structure.
    /// </summary>
    [Serializable]
    public class Retailer : AlipayObject
    {
        /// <summary>
        /// 零售商名称
        /// </summary>
        [JsonProperty("name")]
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 零售商pid
        /// </summary>
        [JsonProperty("partner_id")]
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }
    }
}
