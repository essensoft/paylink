using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InsProdTag Data Structure.
    /// </summary>
    [Serializable]
    public class InsProdTag : AlipayObject
    {
        /// <summary>
        /// 业务标记代码
        /// </summary>
        [JsonProperty("tag_code")]
        [XmlElement("tag_code")]
        public string TagCode { get; set; }

        /// <summary>
        /// 业务标记值
        /// </summary>
        [JsonProperty("tag_value")]
        [XmlElement("tag_value")]
        public string TagValue { get; set; }
    }
}
