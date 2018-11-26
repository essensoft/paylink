using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// UnavailablePeriodInfo Data Structure.
    /// </summary>
    [Serializable]
    public class UnavailablePeriodInfo : AlipayObject
    {
        /// <summary>
        /// 商品不可用时段结束日期。格式为YYYY-MM-DD，如2017-05-03
        /// </summary>
        [JsonProperty("end_day")]
        [XmlElement("end_day")]
        public string EndDay { get; set; }

        /// <summary>
        /// 商品不可用时段开始日期。格式为YYYY-MM-DD，如2017-05-01
        /// </summary>
        [JsonProperty("start_day")]
        [XmlElement("start_day")]
        public string StartDay { get; set; }
    }
}
