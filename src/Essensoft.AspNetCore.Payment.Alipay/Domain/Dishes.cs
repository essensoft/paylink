using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Dishes Data Structure.
    /// </summary>
    public class Dishes : AlipayObject
    {
        /// <summary>
        /// 外部菜品ID  当dish_list[]不为空的时候，dish_id是必填字段。
        /// </summary>
        [JsonPropertyName("dish_id")]
        public string DishId { get; set; }

        /// <summary>
        /// 菜品名称
        /// </summary>
        [JsonPropertyName("dish_name")]
        public string DishName { get; set; }

        /// <summary>
        /// 菜品数量
        /// </summary>
        [JsonPropertyName("dish_num")]
        public string DishNum { get; set; }

        /// <summary>
        /// 菜品价格（单位分）
        /// </summary>
        [JsonPropertyName("dish_price")]
        public string DishPrice { get; set; }

        /// <summary>
        /// 菜品折后价格（单位分）
        /// </summary>
        [JsonPropertyName("dish_real_price")]
        public string DishRealPrice { get; set; }

        /// <summary>
        /// 1234
        /// </summary>
        [JsonPropertyName("dish_skuid")]
        public string DishSkuid { get; set; }
    }
}
