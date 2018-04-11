using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BeaconTemplate Data Structure.
    /// </summary>
    [Serializable]
    public class BeaconTemplate : AlipayObject
    {
        /// <summary>
        /// 模板参数信息
        /// </summary>
        [JsonProperty("context")]
        [XmlElement("context")]
        public string Context { get; set; }

        /// <summary>
        /// 模板ID
        /// </summary>
        [JsonProperty("templateid")]
        [XmlElement("templateid")]
        public string Templateid { get; set; }
    }
}
