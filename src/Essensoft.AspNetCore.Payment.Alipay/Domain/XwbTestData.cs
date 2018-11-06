using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// XwbTestData Data Structure.
    /// </summary>
    [Serializable]
    public class XwbTestData : AlipayObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [JsonProperty("s")]
        [XmlElement("s")]
        public string S { get; set; }
    }
}
