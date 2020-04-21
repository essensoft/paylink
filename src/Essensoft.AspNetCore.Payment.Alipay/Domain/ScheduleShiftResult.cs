using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ScheduleShiftResult Data Structure.
    /// </summary>
    public class ScheduleShiftResult : AlipayObject
    {
        /// <summary>
        /// 返回码
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// 结果
        /// </summary>
        [JsonPropertyName("data")]
        public List<ScheduleShiftItem> Data { get; set; }

        /// <summary>
        /// 结果描述
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; }
    }
}
