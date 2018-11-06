using System;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbdishPropertyInfo Data Structure.
    /// </summary>
    [Serializable]
    public class KbdishPropertyInfo : AlipayObject
    {
        /// <summary>
        /// 菜品属性名称
        /// </summary>
        [JsonProperty("property_name")]
        [XmlElement("property_name")]
        public string PropertyName { get; set; }

        /// <summary>
        /// 菜品销售属性属性值模型
        /// </summary>
        [JsonProperty("property_value_info_list")]
        [XmlArray("property_value_info_list")]
        [XmlArrayItem("kbdish_property_value_info")]
        public List<KbdishPropertyValueInfo> PropertyValueInfoList { get; set; }

        /// <summary>
        /// 菜品属性排序字段，从1一直递增到4
        /// </summary>
        [JsonProperty("sort")]
        [XmlElement("sort")]
        public string Sort { get; set; }
    }
}
