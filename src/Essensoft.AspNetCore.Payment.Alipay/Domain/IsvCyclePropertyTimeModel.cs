using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// IsvCyclePropertyTimeModel Data Structure.
    /// </summary>
    [Serializable]
    public class IsvCyclePropertyTimeModel : AlipayObject
    {
        /// <summary>
        /// 日期
        /// </summary>
        [JsonProperty("date")]
        public string Date { get; set; }

        /// <summary>
        /// * 周期属性时间类型  WEEK("WEEK", "星期"),  DATE("DATE", "日期"),
        /// </summary>
        [JsonProperty("time_type")]
        public string TimeType { get; set; }

        /// <summary>
        /// 星期
        /// </summary>
        [JsonProperty("week")]
        public string Week { get; set; }
    }
}
