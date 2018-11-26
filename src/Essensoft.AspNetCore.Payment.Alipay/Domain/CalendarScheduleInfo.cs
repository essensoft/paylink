using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CalendarScheduleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CalendarScheduleInfo : AlipayObject
    {
        /// <summary>
        /// 时间分段时长，字段unit为单位，如duration=30，unit=MIN，则表示二进制的时间表表示将一天分为30分钟一小段的时间片段，用来表示服务者的时间是否可用
        /// </summary>
        [JsonProperty("duration")]
        [XmlElement("duration")]
        public long Duration { get; set; }

        /// <summary>
        /// 服务者的服务时间表
        /// </summary>
        [JsonProperty("schedule")]
        [XmlArray("schedule")]
        [XmlArrayItem("schedule_info")]
        public List<ScheduleInfo> Schedule { get; set; }

        /// <summary>
        /// 间隔长度单位，默认为MIN（分钟），允许的单位有DAY（天）、WEEK（周）、MONTH(月)
        /// </summary>
        [JsonProperty("unit")]
        [XmlElement("unit")]
        public string Unit { get; set; }
    }
}
