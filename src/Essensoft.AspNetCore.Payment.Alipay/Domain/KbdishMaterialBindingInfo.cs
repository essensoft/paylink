using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbdishMaterialBindingInfo Data Structure.
    /// </summary>
    [Serializable]
    public class KbdishMaterialBindingInfo : AlipayObject
    {
        /// <summary>
        /// 加料id
        /// </summary>
        [JsonProperty("material_id")]
        [XmlElement("material_id")]
        public string MaterialId { get; set; }

        /// <summary>
        /// 菜品加料排序字段，从1开始递增
        /// </summary>
        [JsonProperty("sort")]
        [XmlElement("sort")]
        public string Sort { get; set; }
    }
}
