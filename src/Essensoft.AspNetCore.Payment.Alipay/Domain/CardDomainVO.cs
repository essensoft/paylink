using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CardDomainVO Data Structure.
    /// </summary>
    [Serializable]
    public class CardDomainVO : AlipayObject
    {
        /// <summary>
        /// 值域域名的描述值，固定为”金融”
        /// </summary>
        [JsonProperty("description")]
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 值域域名，固定为“FINANCE”
        /// </summary>
        [JsonProperty("domain_name")]
        [XmlElement("domain_name")]
        public string DomainName { get; set; }
    }
}
