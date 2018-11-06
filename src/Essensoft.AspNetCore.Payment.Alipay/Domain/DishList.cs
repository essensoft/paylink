using System;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DishList Data Structure.
    /// </summary>
    [Serializable]
    public class DishList : AlipayObject
    {
        /// <summary>
        /// 总价
        /// </summary>
        [JsonProperty("amount")]
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 口碑推单的批次号
        /// </summary>
        [JsonProperty("batch_no")]
        [XmlElement("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 菜品优惠金额
        /// </summary>
        [JsonProperty("discount_amount")]
        [XmlElement("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 菜品优惠明细
        /// </summary>
        [JsonProperty("discount_infos")]
        [XmlArray("discount_infos")]
        [XmlArrayItem("discount_infos")]
        public List<DiscountInfos> DiscountInfos { get; set; }

        /// <summary>
        /// 菜品在口碑侧基于商品表达的商品ID
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
        /// 菜品类型：  可枚举：  (1)SINGLE  (2)COMBO
        /// </summary>
        [JsonProperty("dish_type")]
        [XmlElement("dish_type")]
        public string DishType { get; set; }

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
        /// POS侧菜品明细单ID
        /// </summary>
        [JsonProperty("out_detail_id")]
        [XmlElement("out_detail_id")]
        public string OutDetailId { get; set; }

        /// <summary>
        /// 外部菜品ID
        /// </summary>
        [JsonProperty("out_dish_id")]
        [XmlElement("out_dish_id")]
        public string OutDishId { get; set; }

        /// <summary>
        /// "菜品的其他信息，包括但不限于：sku、规格，做法等信息;  为Map结构的json格式，key的枚举定义：  (1)PRACTICE:""红烧""   做法  (2PRACTICE_PRICE:""10.0"" 做法加价  (2)SALES_PROPERTY: {""甜度"":[""五分甜"",""三分甜""],""冰量"":[""少冰""]} 一般销售属性  (3)SPECIFICATION:""大""  规格"
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
        /// 单价
        /// </summary>
        [JsonProperty("price")]
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 套餐选择信息
        /// </summary>
        [JsonProperty("selected_meal_info")]
        [XmlArray("selected_meal_info")]
        [XmlArrayItem("selected_meal_info")]
        public List<SelectedMealInfo> SelectedMealInfo { get; set; }

        /// <summary>
        /// 商品下细分的sku ID
        /// </summary>
        [JsonProperty("sku_id")]
        [XmlElement("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// "菜品状态：  可枚举：  (1)INIT:加菜  (2)SUCCESS:接单  (2)REFUND:退菜  (2)CLOSE:拒单"
        /// </summary>
        [JsonProperty("status")]
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 是否临时车：  可枚举：  (1)Y  (2)N
        /// </summary>
        [JsonProperty("temporary_dish")]
        [XmlElement("temporary_dish")]
        public string TemporaryDish { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        [JsonProperty("unit")]
        [XmlElement("unit")]
        public string Unit { get; set; }
    }
}
