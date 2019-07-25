using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// StockShippingStepInfo Data Structure.
    /// </summary>
    [Serializable]
    public class StockShippingStepInfo : AlipayObject
    {
        /// <summary>
        /// 处理地点
        /// </summary>
        [JsonProperty("event_address")]
        public string EventAddress { get; set; }

        /// <summary>
        /// 处理时间
        /// </summary>
        [JsonProperty("event_time")]
        public string EventTime { get; set; }

        /// <summary>
        /// 扩展
        /// </summary>
        [JsonProperty("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 处理状态
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
