using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityProdAlipaySecurityProdTestModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdAlipaySecurityProdTestModel : AlipayObject
    {
        /// <summary>
        /// ddd
        /// </summary>
        [JsonProperty("cds")]
        [XmlArray("cds")]
        [XmlArrayItem("string")]
        public List<string> Cds { get; set; }

        /// <summary>
        /// aaa
        /// </summary>
        [JsonProperty("ddd")]
        [XmlElement("ddd")]
        public string Ddd { get; set; }
    }
}
