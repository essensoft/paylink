using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringDishRemovedishDeleteModel Data Structure.
    /// </summary>
    public class KoubeiCateringDishRemovedishDeleteModel : AlipayObject
    {
        /// <summary>
        /// 外部菜品id
        /// </summary>
        [JsonPropertyName("out_dish_id")]
        public string OutDishId { get; set; }

        /// <summary>
        /// 外部门店id，口碑门店id和外部门店id二选一必填
        /// </summary>
        [JsonPropertyName("out_shop_id")]
        public string OutShopId { get; set; }

        /// <summary>
        /// 菜品skuId
        /// </summary>
        [JsonPropertyName("out_sku_id")]
        public string OutSkuId { get; set; }

        /// <summary>
        /// 口碑门店id
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }
    }
}
