using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringPosDishQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosDishQueryModel : AlipayObject
    {
        /// <summary>
        /// 菜品的ID
        /// </summary>
        [JsonProperty("dish_id")]
        public string DishId { get; set; }

        /// <summary>
        /// 门店的ID
        /// </summary>
        [JsonProperty("shop_id")]
        public string ShopId { get; set; }
    }
}
