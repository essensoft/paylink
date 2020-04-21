using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SelectedMealSideInfo Data Structure.
    /// </summary>
    public class SelectedMealSideInfo : AlipayObject
    {
        /// <summary>
        /// 套餐的加价.仅当type=COMBO时有效
        /// </summary>
        [JsonPropertyName("add_price")]
        public string AddPrice { get; set; }

        /// <summary>
        /// 菜品ID
        /// </summary>
        [JsonPropertyName("dish_id")]
        public string DishId { get; set; }

        /// <summary>
        /// 菜品名称
        /// </summary>
        [JsonPropertyName("dish_name")]
        public string DishName { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonPropertyName("ext_infos")]
        public string ExtInfos { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        [JsonPropertyName("num")]
        public string Num { get; set; }

        /// <summary>
        /// 外部菜品ID
        /// </summary>
        [JsonPropertyName("out_dish_id")]
        public string OutDishId { get; set; }

        /// <summary>
        /// "菜品的其他信息，包括但不限于：sku、规格，做法等信息;  为Map结构的json格式，key的枚举定义：  (1)PRACTICE:""红烧""   做法  (2)PRACTICE_PRICE:""10.0"" 做法加价  (3)SALES_PROPERTY: {""甜度"":[""五分甜"",""三分甜""],""冰量"":[""少冰""]} 一般销售属性 (4)SPECIFICATION:""大""  规格"
        /// </summary>
        [JsonPropertyName("out_dish_infos")]
        public string OutDishInfos { get; set; }

        /// <summary>
        /// 外部菜品SKU ID
        /// </summary>
        [JsonPropertyName("out_sku_id")]
        public string OutSkuId { get; set; }

        /// <summary>
        /// 加料价格，仅当type=SIDE时有值
        /// </summary>
        [JsonPropertyName("side_price")]
        public string SidePrice { get; set; }

        /// <summary>
        /// 商品下细分的sku ID
        /// </summary>
        [JsonPropertyName("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// 新增）子明细类型：  可枚举：  (1)COMBO 套餐内子明细  (2)SIDE  加料明细
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }
}
