using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoRenthouseKaBaseinfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoRenthouseKaBaseinfoQueryModel : AlipayObject
    {
        /// <summary>
        /// kaCode唯一标识
        /// </summary>
        [JsonProperty("ka_code")]
        [XmlElement("ka_code")]
        public string KaCode { get; set; }
    }
}
