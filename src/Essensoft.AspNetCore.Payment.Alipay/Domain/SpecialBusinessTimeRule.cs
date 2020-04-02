using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SpecialBusinessTimeRule Data Structure.
    /// </summary>
    public class SpecialBusinessTimeRule : AlipayObject
    {
        /// <summary>
        /// 开始日期
        /// </summary>
        [JsonPropertyName("begin_date")]
        public string BeginDate { get; set; }

        /// <summary>
        /// 是否24小时不营业
        /// </summary>
        [JsonPropertyName("close_all_day")]
        public bool CloseAllDay { get; set; }

        /// <summary>
        /// 结束日期
        /// </summary>
        [JsonPropertyName("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 是否24小时营业
        /// </summary>
        [JsonPropertyName("open_all_day")]
        public bool OpenAllDay { get; set; }

        /// <summary>
        /// 当既不是24小时营业也不是24小时不营业时，具体的营业时间段
        /// </summary>
        [JsonPropertyName("open_time_list")]
        public List<TimeRange> OpenTimeList { get; set; }
    }
}
