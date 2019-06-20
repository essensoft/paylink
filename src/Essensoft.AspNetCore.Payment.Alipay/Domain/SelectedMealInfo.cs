using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SelectedMealInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SelectedMealInfo : AlipayObject
    {
        /// <summary>
        /// 套餐的加价.仅当type=COMBO时有效
        /// </summary>
        [JsonProperty("add_price")]
        public string AddPrice { get; set; }

        /// <summary>
        /// 菜品ID
        /// </summary>
        [JsonProperty("dish_id")]
        public string DishId { get; set; }

        /// <summary>
        /// 菜品名称
        /// </summary>
        [JsonProperty("dish_name")]
        public string DishName { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonProperty("ext_infos")]
        public string ExtInfos { get; set; }

        /// <summary>
        /// 套餐子明细的加料信息列表
        /// </summary>
        [JsonProperty("meal_side_list")]
        public List<SelectedMealSideInfo> MealSideList { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        [JsonProperty("num")]
        public string Num { get; set; }

        /// <summary>
        /// 外部菜品ID
        /// </summary>
        [JsonProperty("out_dish_id")]
        public string OutDishId { get; set; }

        /// <summary>
        /// "菜品的其他信息，包括但不限于：sku、规格，做法等信息;  为Map结构的json格式，key的枚举定义：  (1)PRACTICE:""红烧""   做法  (2PRACTICE_PRICE:""10.0"" 做法加价  (3)SALES_PROPERTY: {""甜度"":[""五分甜"",""三分甜""],""冰量"":[""少冰""]} 一般销售属性 (4)SPECIFICATION:""大""  规格"
        /// </summary>
        [JsonProperty("out_dish_infos")]
        public string OutDishInfos { get; set; }

        /// <summary>
        /// 外部菜品SKU ID
        /// </summary>
        [JsonProperty("out_sku_id")]
        public string OutSkuId { get; set; }

        /// <summary>
        /// 加料价格，仅当type=SIDE时有值
        /// </summary>
        [JsonProperty("side_price")]
        public string SidePrice { get; set; }

        /// <summary>
        /// 商品下细分的sku ID
        /// </summary>
        [JsonProperty("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// "（新增）子明细类型：  可枚举：  (1)COMBO 套餐内子明细  (2)SIDE  加料明细"
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        [JsonProperty("unit")]
        public string Unit { get; set; }
    }
}
