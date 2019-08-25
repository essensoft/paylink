using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringPosStallDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosStallDeleteModel : AlipayObject
    {
        /// <summary>
        /// 门店id
        /// </summary>
        [JsonProperty("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 档口id
        /// </summary>
        [JsonProperty("stall_id")]
        public string StallId { get; set; }
    }
}
