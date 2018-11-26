using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniSafedomainCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniSafedomainCreateModel : AlipayObject
    {
        /// <summary>
        /// httpRequest域白名单
        /// </summary>
        [JsonProperty("safe_domain")]
        [XmlElement("safe_domain")]
        public string SafeDomain { get; set; }
    }
}
