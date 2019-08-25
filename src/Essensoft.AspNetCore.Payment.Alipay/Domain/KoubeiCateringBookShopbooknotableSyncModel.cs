using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringBookShopbooknotableSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringBookShopbooknotableSyncModel : AlipayObject
    {
        /// <summary>
        /// 第三方门店ID
        /// </summary>
        [JsonProperty("out_shop_id")]
        public string OutShopId { get; set; }

        /// <summary>
        /// 不可预订时间段
        /// </summary>
        [JsonProperty("refuse_time")]
        public List<string> RefuseTime { get; set; }

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
