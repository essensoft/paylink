using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SelectedMealInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SelectedMealInfo : AlipayObject
    {
        /// <summary>
        /// 菜品ID
        /// </summary>
        [JsonProperty("dish_id")]
        [XmlElement("dish_id")]
        public string DishId { get; set; }

        /// <summary>
        /// 菜品名称
        /// </summary>
        [JsonProperty("dish_name")]
        [XmlElement("dish_name")]
        public string DishName { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonProperty("ext_infos")]
        [XmlElement("ext_infos")]
        public string ExtInfos { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        [JsonProperty("num")]
        [XmlElement("num")]
        public string Num { get; set; }

        /// <summary>
        /// 外部菜品ID
        /// </summary>
        [JsonProperty("out_dish_id")]
        [XmlElement("out_dish_id")]
        public string OutDishId { get; set; }

        /// <summary>
        /// "菜品的其他信息，包括但不限于：sku、规格，做法等信息;  为Map结构的json格式，key的枚举定义：  (1)PRACTICE:""红烧""   做法  (2PRACTICE_PRICE:""10.0"" 做法加价  (3)SALES_PROPERTY: {""甜度"":[""五分甜"",""三分甜""],""冰量"":[""少冰""]} 一般销售属性 (4)SPECIFICATION:""大""  规格"
        /// </summary>
        [JsonProperty("out_dish_infos")]
        [XmlElement("out_dish_infos")]
        public string OutDishInfos { get; set; }

        /// <summary>
        /// 外部菜品SKU ID
        /// </summary>
        [JsonProperty("out_sku_id")]
        [XmlElement("out_sku_id")]
        public string OutSkuId { get; set; }

        /// <summary>
        /// 商品下细分的sku ID
        /// </summary>
        [JsonProperty("sku_id")]
        [XmlElement("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// "（新增）子明细类型：  可枚举：  (1)COMBO 套餐内子明细  (2)SIDE  加料明细"
        /// </summary>
        [JsonProperty("type")]
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        [JsonProperty("unit")]
        [XmlElement("unit")]
        public string Unit { get; set; }
    }
}
