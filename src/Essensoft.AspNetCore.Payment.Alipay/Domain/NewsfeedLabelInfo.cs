using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// NewsfeedLabelInfo Data Structure.
    /// </summary>
    [Serializable]
    public class NewsfeedLabelInfo : AlipayObject
    {
        /// <summary>
        /// 根据主谓宾的格式生成动态的标题，此字段为谓语
        /// </summary>
        [JsonProperty("action")]
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// label行的跳转链接
        /// </summary>
        [JsonProperty("scheme")]
        [XmlElement("scheme")]
        public string Scheme { get; set; }

        /// <summary>
        /// 根据主谓宾的格式生成动态的标题，此字段为宾语
        /// </summary>
        [JsonProperty("target")]
        [XmlElement("target")]
        public string Target { get; set; }
    }
}
