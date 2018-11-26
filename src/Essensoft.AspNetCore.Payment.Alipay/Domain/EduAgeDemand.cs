using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// EduAgeDemand Data Structure.
    /// </summary>
    [Serializable]
    public class EduAgeDemand : AlipayObject
    {
        /// <summary>
        /// 结束年龄
        /// </summary>
        [JsonProperty("age_end")]
        [XmlElement("age_end")]
        public string AgeEnd { get; set; }

        /// <summary>
        /// 开始年龄
        /// </summary>
        [JsonProperty("age_start")]
        [XmlElement("age_start")]
        public string AgeStart { get; set; }
    }
}
