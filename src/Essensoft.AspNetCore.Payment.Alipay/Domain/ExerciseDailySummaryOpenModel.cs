using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ExerciseDailySummaryOpenModel Data Structure.
    /// </summary>
    public class ExerciseDailySummaryOpenModel : AlipayObject
    {
        /// <summary>
        /// 时长：单位秒
        /// </summary>
        [JsonPropertyName("duration")]
        public long Duration { get; set; }

        /// <summary>
        /// 目标类型:CARDIO，MUSCLE，FLEXIBILITY
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
