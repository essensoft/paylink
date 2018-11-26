using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ClaimProgress Data Structure.
    /// </summary>
    [Serializable]
    public class ClaimProgress : AlipayObject
    {
        /// <summary>
        /// 更新内容
        /// </summary>
        [JsonProperty("update_content")]
        [XmlElement("update_content")]
        public string UpdateContent { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("update_time")]
        [XmlElement("update_time")]
        public string UpdateTime { get; set; }
    }
}
