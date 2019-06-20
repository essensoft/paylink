using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ExerciseDailySummaryOpenModel Data Structure.
    /// </summary>
    [Serializable]
    public class ExerciseDailySummaryOpenModel : AlipayObject
    {
        /// <summary>
        /// 时长：单位秒
        /// </summary>
        [JsonProperty("duration")]
        public long Duration { get; set; }

        /// <summary>
        /// 目标类型:CARDIO，MUSCLE，FLEXIBILITY
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
