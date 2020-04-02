using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TimeRange Data Structure.
    /// </summary>
    public class TimeRange : AlipayObject
    {
        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonPropertyName("begin")]
        public string Begin { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [JsonPropertyName("end")]
        public string End { get; set; }
    }
}
