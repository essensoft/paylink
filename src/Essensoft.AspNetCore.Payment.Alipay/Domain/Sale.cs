using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Sale Data Structure.
    /// </summary>
    [Serializable]
    public class Sale : AlipayObject
    {
        /// <summary>
        /// 促销描述内容，有活动的情况下必填
        /// </summary>
        [JsonProperty("describe")]
        [XmlElement("describe")]
        public string Describe { get; set; }

        /// <summary>
        /// 促销活动结束时间，有活动的情况下必填
        /// </summary>
        [JsonProperty("end_time")]
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 促销活动开始时间，有活动的情况下必填
        /// </summary>
        [JsonProperty("start_time")]
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 活动状态，0：有效；1：停用；默认状态0：有效。有活动的情况下必填
        /// </summary>
        [JsonProperty("status")]
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
