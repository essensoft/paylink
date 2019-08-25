using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringQueueShopqueueinfoSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringQueueShopqueueinfoSyncModel : AlipayObject
    {
        /// <summary>
        /// 美味门店ID
        /// </summary>
        [JsonProperty("out_shop_id")]
        public string OutShopId { get; set; }

        /// <summary>
        /// 队列信息
        /// </summary>
        [JsonProperty("queue_list")]
        public List<ShopQueue> QueueList { get; set; }

        /// <summary>
        /// 口碑门店ID
        /// </summary>
        [JsonProperty("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 时间戳，用作数据的版本号，取系统当前时间即可
        /// </summary>
        [JsonProperty("sync_timestamp")]
        public string SyncTimestamp { get; set; }
    }
}
