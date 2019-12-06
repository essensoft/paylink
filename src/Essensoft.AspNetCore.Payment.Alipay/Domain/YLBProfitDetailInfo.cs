using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// YLBProfitDetailInfo Data Structure.
    /// </summary>
    public class YLBProfitDetailInfo : AlipayObject
    {
        /// <summary>
        /// 近1日收益，单位为元
        /// </summary>
        [JsonPropertyName("day_profit")]
        public string DayProfit { get; set; }

        /// <summary>
        /// 近1月收益，单位为元
        /// </summary>
        [JsonPropertyName("month_profit")]
        public string MonthProfit { get; set; }

        /// <summary>
        /// 历史累计收益，单位为元
        /// </summary>
        [JsonPropertyName("total_profit")]
        public string TotalProfit { get; set; }

        /// <summary>
        /// 近1周收益，单位为元
        /// </summary>
        [JsonPropertyName("week_profit")]
        public string WeekProfit { get; set; }
    }
}
