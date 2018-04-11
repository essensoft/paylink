using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniSafedomainDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniSafedomainDeleteModel : AlipayObject
    {
        /// <summary>
        /// httpRequest域白名单
        /// </summary>
        [JsonProperty("safe_domain")]
        [XmlElement("safe_domain")]
        public string SafeDomain { get; set; }
    }
}
