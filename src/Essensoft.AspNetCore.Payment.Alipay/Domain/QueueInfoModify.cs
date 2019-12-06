using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// QueueInfoModify Data Structure.
    /// </summary>
    public class QueueInfoModify : AlipayObject
    {
        /// <summary>
        /// 队列ID
        /// </summary>
        [JsonPropertyName("queue_id")]
        public string QueueId { get; set; }

        /// <summary>
        /// 订单排队号
        /// </summary>
        [JsonPropertyName("queue_no")]
        public string QueueNo { get; set; }

        /// <summary>
        /// 当前等待人数
        /// </summary>
        [JsonPropertyName("queue_wait")]
        public long QueueWait { get; set; }

        /// <summary>
        /// 预计等待时间（单位：分钟）
        /// </summary>
        [JsonPropertyName("queue_wait_time")]
        public long QueueWaitTime { get; set; }
    }
}
