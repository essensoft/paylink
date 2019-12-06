using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringQueueShopinfoSyncModel Data Structure.
    /// </summary>
    public class KoubeiCateringQueueShopinfoSyncModel : AlipayObject
    {
        /// <summary>
        /// 过号是否作废。返回0表示作废；非0表示不作废，并以数字表示过号延几桌。如返回1，表示延一桌，返回2则是延两桌。
        /// </summary>
        [JsonPropertyName("discard_off")]
        public long DiscardOff { get; set; }

        /// <summary>
        /// 等位优惠信息
        /// </summary>
        [JsonPropertyName("discount_desc")]
        public string DiscountDesc { get; set; }

        /// <summary>
        /// 取号距离（单位：米）
        /// </summary>
        [JsonPropertyName("distance_limit")]
        public long DistanceLimit { get; set; }

        /// <summary>
        /// 过号描述
        /// </summary>
        [JsonPropertyName("notice")]
        public string Notice { get; set; }

        /// <summary>
        /// 美味门店ID
        /// </summary>
        [JsonPropertyName("out_shop_id")]
        public string OutShopId { get; set; }

        /// <summary>
        /// 口碑门店ID
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 是否显示号单等待时间。如返回true，则表示是；如返回false，则表示否。
        /// </summary>
        [JsonPropertyName("show_order_wait_time")]
        public bool ShowOrderWaitTime { get; set; }

        /// <summary>
        /// 是否显示排队等待时间。如返回true，则表示是；如返回false，则表示否。
        /// </summary>
        [JsonPropertyName("show_wait_time")]
        public bool ShowWaitTime { get; set; }

        /// <summary>
        /// 时间戳，用作数据的版本号，取系统当前时间即可
        /// </summary>
        [JsonPropertyName("sync_timestamp")]
        public string SyncTimestamp { get; set; }
    }
}
