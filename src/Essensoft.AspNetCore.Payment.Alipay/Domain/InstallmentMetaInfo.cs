using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InstallmentMetaInfo Data Structure.
    /// </summary>
    [Serializable]
    public class InstallmentMetaInfo : AlipayObject
    {
        /// <summary>
        /// 结束期数，包含此值
        /// </summary>
        [JsonProperty("end_term")]
        [XmlElement("end_term")]
        public long EndTerm { get; set; }

        /// <summary>
        /// 开始期数，包含此值
        /// </summary>
        [JsonProperty("start_term")]
        [XmlElement("start_term")]
        public long StartTerm { get; set; }

        /// <summary>
        /// 分期值（如还款方式、利率等）
        /// </summary>
        [JsonProperty("value")]
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
