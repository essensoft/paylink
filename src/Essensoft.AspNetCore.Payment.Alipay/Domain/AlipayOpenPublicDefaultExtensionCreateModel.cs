using System;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicDefaultExtensionCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicDefaultExtensionCreateModel : AlipayObject
    {
        /// <summary>
        /// 默认扩展区列表，最多包含3个扩展区
        /// </summary>
        [JsonProperty("areas")]
        [XmlArray("areas")]
        [XmlArrayItem("extension_area")]
        public List<ExtensionArea> Areas { get; set; }
    }
}
