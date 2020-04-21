using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// IsvCyclePropertyTimeModel Data Structure.
    /// </summary>
    public class IsvCyclePropertyTimeModel : AlipayObject
    {
        /// <summary>
        /// 日期
        /// </summary>
        [JsonPropertyName("date")]
        public string Date { get; set; }

        /// <summary>
        /// * 周期属性时间类型  WEEK("WEEK", "星期"),  DATE("DATE", "日期"),
        /// </summary>
        [JsonPropertyName("time_type")]
        public string TimeType { get; set; }

        /// <summary>
        /// 星期
        /// </summary>
        [JsonPropertyName("week")]
        public string Week { get; set; }
    }
}
