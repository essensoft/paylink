using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AvailablePeriodInfo Data Structure.
    /// </summary>
    public class AvailablePeriodInfo : AlipayObject
    {
        /// <summary>
        /// 每周可用天列表。格式为星期几并用逗号分隔。如周一周二可用则为“1,2”，周五周六可用则为"5,6"
        /// </summary>
        [JsonPropertyName("available_week_days")]
        public string AvailableWeekDays { get; set; }

        /// <summary>
        /// 商品可用时段结束时间。格式HH:mm，如果22：30
        /// </summary>
        [JsonPropertyName("time_end")]
        public string TimeEnd { get; set; }

        /// <summary>
        /// 可用时段开始时间。格式为HH:mm，如08:30
        /// </summary>
        [JsonPropertyName("time_start")]
        public string TimeStart { get; set; }
    }
}
