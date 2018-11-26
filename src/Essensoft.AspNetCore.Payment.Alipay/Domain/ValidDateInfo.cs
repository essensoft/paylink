using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ValidDateInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ValidDateInfo : AlipayObject
    {
        /// <summary>
        /// 截至时间
        /// </summary>
        [JsonProperty("end_time")]
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 相对有效期
        /// </summary>
        [JsonProperty("relative_time")]
        [XmlElement("relative_time")]
        public PeriodInfo RelativeTime { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonProperty("start_time")]
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 时间模式,RELATIVE=相对时间，RELATIVE=绝对模式
        /// </summary>
        [JsonProperty("time_mode")]
        [XmlElement("time_mode")]
        public string TimeMode { get; set; }
    }
}
