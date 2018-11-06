using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MyObjectDdd Data Structure.
    /// </summary>
    [Serializable]
    public class MyObjectDdd : AlipayObject
    {
        /// <summary>
        /// xx
        /// </summary>
        [JsonProperty("item")]
        [XmlElement("item")]
        public string Item { get; set; }

        /// <summary>
        /// xxx
        /// </summary>
        [JsonProperty("param")]
        [XmlElement("param")]
        public string Param { get; set; }
    }
}
