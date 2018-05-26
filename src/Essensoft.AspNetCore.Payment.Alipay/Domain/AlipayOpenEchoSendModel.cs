using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenEchoSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenEchoSendModel : AlipayObject
    {
        /// <summary>
        /// xxx
        /// </summary>
        [JsonProperty("name")]
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
