using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbVirtualShopCategoryDishInfo Data Structure.
    /// </summary>
    public class KbVirtualShopCategoryDishInfo : AlipayObject
    {
        /// <summary>
        /// 口碑菜品id
        /// </summary>
        [JsonPropertyName("dish_id")]
        public string DishId { get; set; }

        /// <summary>
        /// 拓展信息
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 菜品在虚拟类目中的排序值
        /// </summary>
        [JsonPropertyName("sort")]
        public string Sort { get; set; }
    }
}
