using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BusinessHour Data Structure.
    /// </summary>
    public class BusinessHour : AlipayObject
    {
        /// <summary>
        /// 营业截止日期。使用星期值枚举 MON : 星期一;TUE : 星期二;WED : 星期三;THU : 星期四;FRI : 星期五;SAT : 星期六;SUN : 星期天
        /// </summary>
        [JsonPropertyName("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 店铺营业时间段列表,示例:[{"start_date":"13:00","end_date":"14:00"},{"start_date":"17:00","end_date":"18:00"}]
        /// </summary>
        [JsonPropertyName("hour_items")]
        public List<BusinessHourItem> HourItems { get; set; }

        /// <summary>
        /// 营业开始日期。使用星期值枚举 MON : 星期一;TUE : 星期二;WED : 星期三;THU : 星期四;FRI : 星期五;SAT : 星期六;SUN : 星期天
        /// </summary>
        [JsonPropertyName("start_date")]
        public string StartDate { get; set; }
    }
}
