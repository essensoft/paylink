using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringBookShopbooknotableSyncModel Data Structure.
    /// </summary>
    public class KoubeiCateringBookShopbooknotableSyncModel : AlipayObject
    {
        /// <summary>
        /// 第三方门店ID
        /// </summary>
        [JsonPropertyName("out_shop_id")]
        public string OutShopId { get; set; }

        /// <summary>
        /// 不可预订时间段
        /// </summary>
        [JsonPropertyName("refuse_time")]
        public List<string> RefuseTime { get; set; }

        /// <summary>
        /// 口碑门店ID
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 时间戳，用作数据的版本号，取系统当前时间即可
        /// </summary>
        [JsonPropertyName("sync_timestamp")]
        public string SyncTimestamp { get; set; }
    }
}
