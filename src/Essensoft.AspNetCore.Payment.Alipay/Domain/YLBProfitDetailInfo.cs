using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// YLBProfitDetailInfo Data Structure.
    /// </summary>
    [Serializable]
    public class YLBProfitDetailInfo : AlipayObject
    {
        /// <summary>
        /// 近1日收益，单位为元
        /// </summary>
        [JsonProperty("day_profit")]
        [XmlElement("day_profit")]
        public string DayProfit { get; set; }

        /// <summary>
        /// 近1月收益，单位为元
        /// </summary>
        [JsonProperty("month_profit")]
        [XmlElement("month_profit")]
        public string MonthProfit { get; set; }

        /// <summary>
        /// 历史累计收益，单位为元
        /// </summary>
        [JsonProperty("total_profit")]
        [XmlElement("total_profit")]
        public string TotalProfit { get; set; }

        /// <summary>
        /// 近1周收益，单位为元
        /// </summary>
        [JsonProperty("week_profit")]
        [XmlElement("week_profit")]
        public string WeekProfit { get; set; }
    }
}
