using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// QueryGroup Data Structure.
    /// </summary>
    [Serializable]
    public class QueryGroup : AlipayObject
    {
        /// <summary>
        /// 分组id
        /// </summary>
        [JsonProperty("id")]
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 分组中的圈人规则
        /// </summary>
        [JsonProperty("label_rule")]
        [XmlArray("label_rule")]
        [XmlArrayItem("query_complex_label_rule")]
        public List<QueryComplexLabelRule> LabelRule { get; set; }

        /// <summary>
        /// 用户分组名称
        /// </summary>
        [JsonProperty("name")]
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
