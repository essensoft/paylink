using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ScheduleWorkResult Data Structure.
    /// </summary>
    public class ScheduleWorkResult : AlipayObject
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
        public ScheduleWorkItems Data { get; set; }

        /// <summary>
        /// 返回码描述
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; }
    }
}
