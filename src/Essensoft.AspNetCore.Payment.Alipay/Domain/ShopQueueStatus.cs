using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ShopQueueStatus Data Structure.
    /// </summary>
    [Serializable]
    public class ShopQueueStatus : AlipayObject
    {
        /// <summary>
        /// 队列ID
        /// </summary>
        [JsonProperty("queue_id")]
        public string QueueId { get; set; }

        /// <summary>
        /// 队列状态。如enable表示可取号；disable表示不可取号。
        /// </summary>
        [JsonProperty("queue_status")]
        public string QueueStatus { get; set; }

        /// <summary>
        /// 当前等待人数
        /// </summary>
        [JsonProperty("queue_wait")]
        public long QueueWait { get; set; }

        /// <summary>
        /// 当前等待时间（单位：分钟）。如无法预估传-1即可。
        /// </summary>
        [JsonProperty("queue_wait_time")]
        public long QueueWaitTime { get; set; }
    }
}
