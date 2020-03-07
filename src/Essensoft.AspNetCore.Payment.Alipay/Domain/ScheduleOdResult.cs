using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ScheduleOdResult Data Structure.
    /// </summary>
    public class ScheduleOdResult : AlipayObject
    {
        /// <summary>
        /// 返回码
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// 结果列表
        /// </summary>
        [JsonPropertyName("data")]
        public List<ScheduleOdItem> Data { get; set; }

        /// <summary>
        /// 返回状态描述
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; }
    }
}
