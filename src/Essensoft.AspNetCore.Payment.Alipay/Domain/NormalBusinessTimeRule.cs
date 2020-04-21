using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// NormalBusinessTimeRule Data Structure.
    /// </summary>
    public class NormalBusinessTimeRule : AlipayObject
    {
        /// <summary>
        /// 指定月份,当为全年时，传入1,2,3,4,5,6,7,8,9,10,11,12
        /// </summary>
        [JsonPropertyName("month")]
        public List<long> Month { get; set; }

        /// <summary>
        /// 营业时间的时间段
        /// </summary>
        [JsonPropertyName("open_time_list")]
        public List<TimeRange> OpenTimeList { get; set; }

        /// <summary>
        /// 星期
        /// </summary>
        [JsonPropertyName("week")]
        public List<long> Week { get; set; }
    }
}
