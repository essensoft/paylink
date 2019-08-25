using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KdsDishGroupInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class KdsDishGroupInfoDTO : AlipayObject
    {
        /// <summary>
        /// 菜品制作耗时，单位分钟
        /// </summary>
        [JsonProperty("cook_cost")]
        public long CookCost { get; set; }

        /// <summary>
        /// 口碑菜品ID
        /// </summary>
        [JsonProperty("dish_id")]
        public string DishId { get; set; }

        /// <summary>
        /// 菜品名称
        /// </summary>
        [JsonProperty("dish_name")]
        public string DishName { get; set; }

        /// <summary>
        /// 口碑菜品skuID
        /// </summary>
        [JsonProperty("dish_sku_id")]
        public string DishSkuId { get; set; }

        /// <summary>
        /// 菜品时间：非预约单是接单时间，预约单是预约时间
        /// </summary>
        [JsonProperty("dish_time")]
        public string DishTime { get; set; }

        /// <summary>
        /// 菜品单位
        /// </summary>
        [JsonProperty("dish_unit")]
        public string DishUnit { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [JsonProperty("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 菜品一次性可制作最大份数
        /// </summary>
        [JsonProperty("max_cook_num")]
        public long MaxCookNum { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 外部菜品ID
        /// </summary>
        [JsonProperty("out_dish_id")]
        public string OutDishId { get; set; }

        /// <summary>
        /// 外部菜品信息(JSON格式)
        /// </summary>
        [JsonProperty("out_dish_info")]
        public string OutDishInfo { get; set; }

        /// <summary>
        /// 外部菜品skuID
        /// </summary>
        [JsonProperty("out_dish_sku_id")]
        public string OutDishSkuId { get; set; }

        /// <summary>
        /// 加料的归属菜的out_dish_id. 备注: 仅套餐子菜加料需要, 单菜加料不需要填写.
        /// </summary>
        [JsonProperty("out_parent_id")]
        public string OutParentId { get; set; }

        /// <summary>
        /// 做法描述
        /// </summary>
        [JsonProperty("practice_desc")]
        public string PracticeDesc { get; set; }

        /// <summary>
        /// 做法ID
        /// </summary>
        [JsonProperty("practice_id")]
        public string PracticeId { get; set; }

        /// <summary>
        /// 菜品数量
        /// </summary>
        [JsonProperty("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 销售属性(预留字段)
        /// </summary>
        [JsonProperty("sales_properties")]
        public string SalesProperties { get; set; }

        /// <summary>
        /// sku规格描述
        /// </summary>
        [JsonProperty("sku_spec_desc")]
        public string SkuSpecDesc { get; set; }

        /// <summary>
        /// 规格ID
        /// </summary>
        [JsonProperty("spec_id")]
        public string SpecId { get; set; }

        /// <summary>
        /// 菜品类型. "SINGLE": 单品; "SIDE": 加料; "COMBO": 套餐"; "COMBO_SINGLE": 套餐内单品  type 校验规则: 1. 单品/加料 type=SINGLE/SIDE 2. 套餐: 一级type=COMBO, dish_group_info里的子菜type=COMBO_SINGLE 3. 无法同步到口碑的套餐 (只能打平后同步). type=COMBO_SINGLE
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
