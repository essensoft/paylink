using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ReservationTimeUnit Data Structure.
    /// </summary>
    [Serializable]
    public class ReservationTimeUnit : AlipayObject
    {
        /// <summary>
        /// 时间，格式HH:mm
        /// </summary>
        [JsonProperty("time")]
        public string Time { get; set; }

        /// <summary>
        /// 当日CURRENT_DAY  次日NEXT_DAY
        /// </summary>
        [JsonProperty("time_type")]
        public string TimeType { get; set; }
    }
}
