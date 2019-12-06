using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ShieldDishList Data Structure.
    /// </summary>
    public class ShieldDishList : AlipayObject
    {
        /// <summary>
        /// 菜品ID
        /// </summary>
        [JsonPropertyName("dish_id")]
        public string DishId { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonPropertyName("ext_infos")]
        public string ExtInfos { get; set; }

        /// <summary>
        /// 菜品数量
        /// </summary>
        [JsonPropertyName("num")]
        public string Num { get; set; }

        /// <summary>
        /// 菜品下细分的sku ID
        /// </summary>
        [JsonPropertyName("sku_id")]
        public string SkuId { get; set; }
    }
}
