using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringDishQuerydishQueryModel Data Structure.
    /// </summary>
    public class KoubeiCateringDishQuerydishQueryModel : AlipayObject
    {
        /// <summary>
        /// 外部菜品id
        /// </summary>
        [JsonPropertyName("out_dish_id")]
        public string OutDishId { get; set; }

        /// <summary>
        /// 外部门店id，必填逻辑为：与口碑门店id二选一；当菜为门店菜时必须传门店id，否则查询不到菜品。
        /// </summary>
        [JsonPropertyName("out_shop_id")]
        public string OutShopId { get; set; }

        /// <summary>
        /// 口碑门店id
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }
    }
}
