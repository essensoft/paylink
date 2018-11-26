using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// HoloGraphicContactInfo Data Structure.
    /// </summary>
    [Serializable]
    public class HoloGraphicContactInfo : AlipayObject
    {
        /// <summary>
        /// 主叫通话频次
        /// </summary>
        [JsonProperty("call_frequency")]
        [XmlElement("call_frequency")]
        public long CallFrequency { get; set; }

        /// <summary>
        /// 主叫通话时长
        /// </summary>
        [JsonProperty("call_time")]
        [XmlElement("call_time")]
        public long CallTime { get; set; }

        /// <summary>
        /// 被叫通话频次
        /// </summary>
        [JsonProperty("called_frequency")]
        [XmlElement("called_frequency")]
        public long CalledFrequency { get; set; }

        /// <summary>
        /// 被叫通话时长
        /// </summary>
        [JsonProperty("called_time")]
        [XmlElement("called_time")]
        public long CalledTime { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [JsonProperty("mobile")]
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 通话频次
        /// </summary>
        [JsonProperty("talk_frequency")]
        [XmlElement("talk_frequency")]
        public long TalkFrequency { get; set; }

        /// <summary>
        /// 通话时长
        /// </summary>
        [JsonProperty("talk_time")]
        [XmlElement("talk_time")]
        public long TalkTime { get; set; }
    }
}
