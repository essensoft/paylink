using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbdishAreaFreeInfo Data Structure.
    /// </summary>
    public class KbdishAreaFreeInfo : AlipayObject
    {
        /// <summary>
        /// 餐区id
        /// </summary>
        [JsonPropertyName("area_id")]
        public string AreaId { get; set; }

        /// <summary>
        /// 份数
        /// </summary>
        [JsonPropertyName("count")]
        public string Count { get; set; }

        /// <summary>
        /// 口碑菜品id
        /// </summary>
        [JsonPropertyName("dish_id")]
        public string DishId { get; set; }

        /// <summary>
        /// sku_id
        /// </summary>
        [JsonPropertyName("dish_sku_id")]
        public string DishSkuId { get; set; }

        /// <summary>
        /// open 启动 stop 停用
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
