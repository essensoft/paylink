using System;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayPlatformUseridGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPlatformUseridGetModel : AlipayObject
    {
        /// <summary>
        /// openId的列表
        /// </summary>
        [JsonProperty("open_ids")]
        [XmlArray("open_ids")]
        [XmlArrayItem("string")]
        public List<string> OpenIds { get; set; }
    }
}
