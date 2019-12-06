using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PosFixedDishGroupModel Data Structure.
    /// </summary>
    public class PosFixedDishGroupModel : AlipayObject
    {
        /// <summary>
        /// 固定菜的数量，有固定菜时必传
        /// </summary>
        [JsonPropertyName("count")]
        public long Count { get; set; }

        /// <summary>
        /// 选中的sku的规格中文名
        /// </summary>
        [JsonPropertyName("detail_sku_spec_name")]
        public string DetailSkuSpecName { get; set; }

        /// <summary>
        /// 菜品的单位中文名
        /// </summary>
        [JsonPropertyName("detail_sku_unit_name")]
        public string DetailSkuUnitName { get; set; }

        /// <summary>
        /// 固定菜的菜品ID，有固定菜时必传
        /// </summary>
        [JsonPropertyName("dish_id")]
        public string DishId { get; set; }

        /// <summary>
        /// 固定菜名字，仅在查询返回时返回
        /// </summary>
        [JsonPropertyName("dish_name")]
        public string DishName { get; set; }

        /// <summary>
        /// 固定菜的组ID，更新的时候需要传
        /// </summary>
        [JsonPropertyName("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 固定菜的售价,有固定菜时必传
        /// </summary>
        [JsonPropertyName("sell_price")]
        public string SellPrice { get; set; }

        /// <summary>
        /// 固定菜的SKU的id，有固定菜时必传
        /// </summary>
        [JsonPropertyName("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// 固定菜的排序字段，有固定菜时必传
        /// </summary>
        [JsonPropertyName("sort")]
        public long Sort { get; set; }
    }
}
