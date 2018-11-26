using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppSilanApigrayoneQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppSilanApigrayoneQueryModel : AlipayObject
    {
        /// <summary>
        /// param
        /// </summary>
        [JsonProperty("param_1")]
        [XmlElement("param_1")]
        public string Param1 { get; set; }
    }
}
