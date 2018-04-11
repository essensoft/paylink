using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// LabelContext Data Structure.
    /// </summary>
    [Serializable]
    public class LabelContext : AlipayObject
    {
        /// <summary>
        /// 标签组发圈人的单个过滤器信息
        /// </summary>
        [JsonProperty("a")]
        [XmlElement("a")]
        public LabelFilter A { get; set; }
    }
}
