using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AssuranceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AssuranceInfo : AlipayObject
    {
        /// <summary>
        /// 服务保障的描述
        /// </summary>
        [JsonProperty("description")]
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 服务保障的标题
        /// </summary>
        [JsonProperty("title")]
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
