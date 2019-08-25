using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiServindustryReservationResourceSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiServindustryReservationResourceSyncModel : AlipayObject
    {
        /// <summary>
        /// 口碑为第三方ISV分配的渠道标识，如K米的渠道为KMI
        /// </summary>
        [JsonProperty("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 行业，如KTV，MASSAGE(足疗)等
        /// </summary>
        [JsonProperty("industry")]
        public string Industry { get; set; }

        /// <summary>
        /// 商户在ISV创建的门店id
        /// </summary>
        [JsonProperty("out_shop_id")]
        public string OutShopId { get; set; }

        /// <summary>
        /// 商户在口碑创建的门店id
        /// </summary>
        [JsonProperty("shop_id")]
        public string ShopId { get; set; }
    }
}
