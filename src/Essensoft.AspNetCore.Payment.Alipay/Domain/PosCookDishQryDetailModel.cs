using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PosCookDishQryDetailModel Data Structure.
    /// </summary>
    [Serializable]
    public class PosCookDishQryDetailModel : AlipayObject
    {
        /// <summary>
        /// 菜品对应的售卖类别的ID
        /// </summary>
        [JsonProperty("category_big_id")]
        public string CategoryBigId { get; set; }

        /// <summary>
        /// 菜品的ID
        /// </summary>
        [JsonProperty("dish_id")]
        public string DishId { get; set; }

        /// <summary>
        /// 菜品素材库的ID
        /// </summary>
        [JsonProperty("dish_img")]
        public string DishImg { get; set; }

        /// <summary>
        /// 菜品的名字
        /// </summary>
        [JsonProperty("dish_name")]
        public string DishName { get; set; }

        /// <summary>
        /// 菜品和档口的关系（多个档口以逗号,分隔）
        /// </summary>
        [JsonProperty("dish_stall_ref")]
        public string DishStallRef { get; set; }

        /// <summary>
        /// 菜品的最低售卖价格
        /// </summary>
        [JsonProperty("min_price")]
        public string MinPrice { get; set; }

        /// <summary>
        /// true false 是否是多规格
        /// </summary>
        [JsonProperty("multi_spec")]
        public bool MultiSpec { get; set; }

        /// <summary>
        /// 新品或者招牌 标签
        /// </summary>
        [JsonProperty("special_tag")]
        public string SpecialTag { get; set; }

        /// <summary>
        /// 辣度
        /// </summary>
        [JsonProperty("spicy_tag")]
        public string SpicyTag { get; set; }

        /// <summary>
        /// 菜品的售卖状态
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// 菜品的类型
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// 菜品单位
        /// </summary>
        [JsonProperty("unit_name")]
        public string UnitName { get; set; }
    }
}
