using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicPersonalizedExtensionCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicPersonalizedExtensionCreateModel : AlipayObject
    {
        /// <summary>
        /// 扩展区列表，最大条数为3
        /// </summary>
        [JsonProperty("areas")]
        [XmlArray("areas")]
        [XmlArrayItem("extension_area")]
        public List<ExtensionArea> Areas { get; set; }

        /// <summary>
        /// 标签规则，目前限定只能传入1条，在扩展区上线后，满足该标签规则的用户进入生活号首页，将看到该套扩展区。
        /// </summary>
        [JsonProperty("label_rule")]
        [XmlArray("label_rule")]
        [XmlArrayItem("label_rule")]
        public List<LabelRule> LabelRule { get; set; }
    }
}
