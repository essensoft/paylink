using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// QueryExtension Data Structure.
    /// </summary>
    [Serializable]
    public class QueryExtension : AlipayObject
    {
        /// <summary>
        /// 扩展区列表
        /// </summary>
        [JsonProperty("areas")]
        [XmlArray("areas")]
        [XmlArrayItem("extension_area")]
        public List<ExtensionArea> Areas { get; set; }

        /// <summary>
        /// 扩展区套id
        /// </summary>
        [JsonProperty("extension_key")]
        [XmlElement("extension_key")]
        public string ExtensionKey { get; set; }

        /// <summary>
        /// 标签规则列表
        /// </summary>
        [JsonProperty("label_rules")]
        [XmlArray("label_rules")]
        [XmlArrayItem("query_label_rule")]
        public List<QueryLabelRule> LabelRules { get; set; }

        /// <summary>
        /// 扩展区状态，"ON"代表上线，"OFF"代表下线，只有上线的扩展区才能被用户看到
        /// </summary>
        [JsonProperty("status")]
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
