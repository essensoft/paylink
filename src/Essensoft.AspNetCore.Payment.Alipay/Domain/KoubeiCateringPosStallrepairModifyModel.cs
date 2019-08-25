using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringPosStallrepairModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosStallrepairModifyModel : AlipayObject
    {
        /// <summary>
        /// 菜品id
        /// </summary>
        [JsonProperty("dish_id")]
        public string DishId { get; set; }

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
