using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// QueryMenu Data Structure.
    /// </summary>
    [Serializable]
    public class QueryMenu : AlipayObject
    {
        /// <summary>
        /// 一级菜单列表
        /// </summary>
        [JsonProperty("button")]
        [XmlArray("button")]
        [XmlArrayItem("button_object")]
        public List<ButtonObject> Button { get; set; }

        /// <summary>
        /// 标签规则项列表
        /// </summary>
        [JsonProperty("label_rule")]
        [XmlArray("label_rule")]
        [XmlArrayItem("query_label_rule")]
        public List<QueryLabelRule> LabelRule { get; set; }

        /// <summary>
        /// 菜单唯一id
        /// </summary>
        [JsonProperty("menu_key")]
        [XmlElement("menu_key")]
        public string MenuKey { get; set; }

        /// <summary>
        /// 菜单类型，icon：icon型菜单，text：文本型菜单
        /// </summary>
        [JsonProperty("type")]
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
