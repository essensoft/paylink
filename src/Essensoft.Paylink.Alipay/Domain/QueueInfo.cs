using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// QueueInfo Data Structure.
    /// </summary>
    public class QueueInfo : AlipayObject
    {
        /// <summary>
        /// 当前叫号
        /// </summary>
        [JsonPropertyName("current_num")]
        public string CurrentNum { get; set; }

        /// <summary>
        /// 就餐人数
        /// </summary>
        [JsonPropertyName("dining_num")]
        public string DiningNum { get; set; }

        /// <summary>
        /// 排队号
        /// </summary>
        [JsonPropertyName("queue_num")]
        public string QueueNum { get; set; }

        /// <summary>
        /// 预计还需多少时间
        /// </summary>
        [JsonPropertyName("still_wait_time")]
        public string StillWaitTime { get; set; }

        /// <summary>
        /// 桌型
        /// </summary>
        [JsonPropertyName("table_type")]
        public string TableType { get; set; }

        /// <summary>
        /// 前面还有多少桌
        /// </summary>
        [JsonPropertyName("wait_num")]
        public string WaitNum { get; set; }

        /// <summary>
        /// 已等待时间
        /// </summary>
        [JsonPropertyName("waiting_time")]
        public string WaitingTime { get; set; }
    }
}
