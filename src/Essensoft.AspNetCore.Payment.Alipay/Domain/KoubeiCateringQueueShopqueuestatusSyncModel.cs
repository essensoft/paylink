using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringQueueShopqueuestatusSyncModel Data Structure.
    /// </summary>
    public class KoubeiCateringQueueShopqueuestatusSyncModel : AlipayObject
    {
        /// <summary>
        /// 美味门店ID
        /// </summary>
        [JsonPropertyName("out_shop_id")]
        public string OutShopId { get; set; }

        /// <summary>
        /// 队列信息
        /// </summary>
        [JsonPropertyName("queue_list")]
        public List<ShopQueueStatus> QueueList { get; set; }

        /// <summary>
        /// 口碑门店ID
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 门店状态。如online_take表示可线上取号；not_need_queue表示不用排队(商家联网)；only_onsite_take表示仅现场取号；not_open表示未营业(未联网)
        /// </summary>
        [JsonPropertyName("shop_state")]
        public string ShopState { get; set; }

        /// <summary>
        /// 时间戳，用作数据的版本号，取系统当前时间即可
        /// </summary>
        [JsonPropertyName("sync_timestamp")]
        public string SyncTimestamp { get; set; }
    }
}
