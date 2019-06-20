using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PosDishQryModel Data Structure.
    /// </summary>
    [Serializable]
    public class PosDishQryModel : AlipayObject
    {
        /// <summary>
        /// 菜品类别
        /// </summary>
        [JsonProperty("category_big_id")]
        public string CategoryBigId { get; set; }

        /// <summary>
        /// 菜品类别中文名
        /// </summary>
        [JsonProperty("category_big_name")]
        public string CategoryBigName { get; set; }

        /// <summary>
        /// 组合菜的列表
        /// </summary>
        [JsonProperty("choose_dish_group_list")]
        public List<PosDishGroupModel> ChooseDishGroupList { get; set; }

        /// <summary>
        /// 菜品的ID
        /// </summary>
        [JsonProperty("dish_id")]
        public string DishId { get; set; }

        /// <summary>
        /// 菜品图片素材库ID
        /// </summary>
        [JsonProperty("dish_img")]
        public string DishImg { get; set; }

        /// <summary>
        /// 菜品的名字
        /// </summary>
        [JsonProperty("dish_name")]
        public string DishName { get; set; }

        /// <summary>
        /// 拼音助记码
        /// </summary>
        [JsonProperty("en_remember_code")]
        public string EnRememberCode { get; set; }

        /// <summary>
        /// 固定菜列表
        /// </summary>
        [JsonProperty("fixed_dish_group_list")]
        public List<PosFixedDishGroupModel> FixedDishGroupList { get; set; }

        /// <summary>
        /// 制作时长，单位：秒
        /// </summary>
        [JsonProperty("making_time")]
        public long MakingTime { get; set; }

        /// <summary>
        /// 配菜列表
        /// </summary>
        [JsonProperty("material_list")]
        public List<PosDishMaterialModel> MaterialList { get; set; }

        /// <summary>
        /// 单次最大制作份数
        /// </summary>
        [JsonProperty("max_copies_per_time")]
        public long MaxCopiesPerTime { get; set; }

        /// <summary>
        /// 最小份数
        /// </summary>
        [JsonProperty("min_serving")]
        public long MinServing { get; set; }

        /// <summary>
        /// 数字助记码
        /// </summary>
        [JsonProperty("nb_remember_code")]
        public string NbRememberCode { get; set; }

        /// <summary>
        /// 菜品做法列表
        /// </summary>
        [JsonProperty("practice_list")]
        public List<PosDishPracticeModel> PracticeList { get; set; }

        /// <summary>
        /// 菜品描述
        /// </summary>
        [JsonProperty("remarks")]
        public string Remarks { get; set; }

        /// <summary>
        /// sku列表
        /// </summary>
        [JsonProperty("sku_list")]
        public List<PosSkuModel> SkuList { get; set; }

        /// <summary>
        /// 档口列表
        /// </summary>
        [JsonProperty("stall_list")]
        public List<PosStallModel> StallList { get; set; }

        /// <summary>
        /// 菜品的售卖状态  open 起售  stop 停售
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// 菜品标签
        /// </summary>
        [JsonProperty("tags")]
        public string Tags { get; set; }

        /// <summary>
        /// 菜品大类
        /// </summary>
        [JsonProperty("type_big")]
        public string TypeBig { get; set; }

        /// <summary>
        /// 菜品小类
        /// </summary>
        [JsonProperty("type_small")]
        public string TypeSmall { get; set; }

        /// <summary>
        /// 菜品单位
        /// </summary>
        [JsonProperty("unit_name")]
        public string UnitName { get; set; }
    }
}
