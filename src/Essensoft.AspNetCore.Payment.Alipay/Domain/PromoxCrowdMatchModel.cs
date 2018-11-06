using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PromoxCrowdMatchModel Data Structure.
    /// </summary>
    [Serializable]
    public class PromoxCrowdMatchModel : AlipayObject
    {
        /// <summary>
        /// 客群码
        /// </summary>
        [JsonProperty("crowd_code")]
        [XmlElement("crowd_code")]
        public string CrowdCode { get; set; }

        /// <summary>
        /// 是否匹配
        /// </summary>
        [JsonProperty("is_match")]
        [XmlElement("is_match")]
        public bool IsMatch { get; set; }
    }
}
