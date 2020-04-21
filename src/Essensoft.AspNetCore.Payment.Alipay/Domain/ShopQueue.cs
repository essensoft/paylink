using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ShopQueue Data Structure.
    /// </summary>
    public class ShopQueue : AlipayObject
    {
        /// <summary>
        /// 队列最大人数
        /// </summary>
        [JsonPropertyName("max_queue_num")]
        public long MaxQueueNum { get; set; }

        /// <summary>
        /// 队列最小人数
        /// </summary>
        [JsonPropertyName("min_queue_num")]
        public long MinQueueNum { get; set; }

        /// <summary>
        /// 队列描述
        /// </summary>
        [JsonPropertyName("queue_desc")]
        public string QueueDesc { get; set; }

        /// <summary>
        /// 队列ID。作为队列唯一主键，调用方应保证此字段在同一门店内唯一。
        /// </summary>
        [JsonPropertyName("queue_id")]
        public string QueueId { get; set; }

        /// <summary>
        /// 队列名字
        /// </summary>
        [JsonPropertyName("queue_name")]
        public string QueueName { get; set; }

        /// <summary>
        /// 队列类型。  如NONVIP表示默认非VIP；VIP1表示VIP1队；VIP2表示VIP2队列
        /// </summary>
        [JsonPropertyName("queue_option")]
        public string QueueOption { get; set; }

        /// <summary>
        /// 队列前缀
        /// </summary>
        [JsonPropertyName("queue_prefix")]
        public string QueuePrefix { get; set; }
    }
}
