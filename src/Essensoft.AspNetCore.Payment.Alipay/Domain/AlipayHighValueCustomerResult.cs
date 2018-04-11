using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayHighValueCustomerResult Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayHighValueCustomerResult : AlipayObject
    {
        /// <summary>
        /// Z0-Z7
        /// </summary>
        [JsonProperty("level")]
        [XmlElement("level")]
        public string Level { get; set; }
    }
}
