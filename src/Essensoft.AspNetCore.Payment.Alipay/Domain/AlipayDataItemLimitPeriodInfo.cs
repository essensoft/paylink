using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataItemLimitPeriodInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataItemLimitPeriodInfo : AlipayObject
    {
        /// <summary>
        /// 区间范围枚举，分为： INCLUDE（包含） EXCLUDE（排除）
        /// </summary>
        [JsonProperty("rule")]
        [XmlElement("rule")]
        public string Rule { get; set; }

        /// <summary>
        /// 单位描述，分为：  MINUTE（分钟）  HOUR（小时）  WEEK_DAY（星期几）  DAY（日）  WEEK（周）  MONTH（月）  ALL（整个销售周期）
        /// </summary>
        [JsonProperty("unit")]
        [XmlElement("unit")]
        public string Unit { get; set; }

        /// <summary>
        /// 区间范围值
        /// </summary>
        [JsonProperty("value")]
        [XmlArray("value")]
        [XmlArrayItem("number")]
        public List<long> Value { get; set; }
    }
}
