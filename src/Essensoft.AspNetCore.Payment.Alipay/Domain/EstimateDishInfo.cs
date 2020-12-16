using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// EstimateDishInfo Data Structure.
    /// </summary>
    public class EstimateDishInfo : AlipayObject
    {
        /// <summary>
        /// 口碑菜品id
        /// </summary>
        [JsonPropertyName("dish_id")]
        public string DishId { get; set; }

        /// <summary>
        /// 库存数量
        /// </summary>
        [JsonPropertyName("inventory")]
        public string Inventory { get; set; }

        /// <summary>
        /// 外部菜品id
        /// </summary>
        [JsonPropertyName("out_dish_id")]
        public string OutDishId { get; set; }
    }
}
