using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// StockShippingStepInfo Data Structure.
    /// </summary>
    public class StockShippingStepInfo : AlipayObject
    {
        /// <summary>
        /// 处理地点
        /// </summary>
        [JsonPropertyName("event_address")]
        public string EventAddress { get; set; }

        /// <summary>
        /// 处理时间
        /// </summary>
        [JsonPropertyName("event_time")]
        public string EventTime { get; set; }

        /// <summary>
        /// 扩展
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 处理状态
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
