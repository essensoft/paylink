using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PosDishModel Data Structure.
    /// </summary>
    public class PosDishModel : AlipayObject
    {
        /// <summary>
        /// 菜品大类的ID，除了删除，其他情况必传
        /// </summary>
        [JsonPropertyName("category_big_id")]
        public string CategoryBigId { get; set; }

        /// <summary>
        /// 组合菜的列表，如果是套餐，那这个必传
        /// </summary>
        [JsonPropertyName("choose_dish_group_list")]
        public List<PosChooseDishGroupModel> ChooseDishGroupList { get; set; }

        /// <summary>
        /// 关联的菜谱的ID，一期的时候是必传的
        /// </summary>
        [JsonPropertyName("cook_id")]
        public string CookId { get; set; }

        /// <summary>
        /// 创建者的ID，新建的时候必传
        /// </summary>
        [JsonPropertyName("create_user")]
        public string CreateUser { get; set; }

        /// <summary>
        /// 菜品的ID，更新和删除时候必传
        /// </summary>
        [JsonPropertyName("dish_id")]
        public string DishId { get; set; }

        /// <summary>
        /// 菜品图片ID，请使用素材库的ID
        /// </summary>
        [JsonPropertyName("dish_img")]
        public string DishImg { get; set; }

        /// <summary>
        /// 菜品的名字，除了删除，其他情况必传
        /// </summary>
        [JsonPropertyName("dish_name")]
        public string DishName { get; set; }

        /// <summary>
        /// 菜品SKU的列表，新增，更新套餐时候是必传的  删除时可以不传
        /// </summary>
        [JsonPropertyName("dish_sku_list")]
        public List<PosSkuModel> DishSkuList { get; set; }

        /// <summary>
        /// 拼音助记码
        /// </summary>
        [JsonPropertyName("en_remember_code")]
        public string EnRememberCode { get; set; }

        /// <summary>
        /// 套餐固定菜的列表，如果是套餐有固定菜，那就必传
        /// </summary>
        [JsonPropertyName("fixed_dish_group_list")]
        public List<PosFixedDishGroupModel> FixedDishGroupList { get; set; }

        /// <summary>
        /// 制作时长，单位：秒
        /// </summary>
        [JsonPropertyName("making_time")]
        public long MakingTime { get; set; }

        /// <summary>
        /// 配料的ID列表
        /// </summary>
        [JsonPropertyName("material_list")]
        public List<PosDishMaterialModel> MaterialList { get; set; }

        /// <summary>
        /// 单次最大制作份数
        /// </summary>
        [JsonPropertyName("max_copies_per_time")]
        public long MaxCopiesPerTime { get; set; }

        /// <summary>
        /// 最低起点份数，除了删除，其他情况必传
        /// </summary>
        [JsonPropertyName("min_serving")]
        public long MinServing { get; set; }

        /// <summary>
        /// 数字助记码
        /// </summary>
        [JsonPropertyName("nb_remember_code")]
        public string NbRememberCode { get; set; }

        /// <summary>
        /// 菜品做法的列表
        /// </summary>
        [JsonPropertyName("practice_list")]
        public List<PosDishPracticeModel> PracticeList { get; set; }

        /// <summary>
        /// 菜品的描述
        /// </summary>
        [JsonPropertyName("remarks")]
        public string Remarks { get; set; }

        /// <summary>
        /// 菜品售卖价格
        /// </summary>
        [JsonPropertyName("sell_price")]
        public string SellPrice { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 打印档口的ID列表
        /// </summary>
        [JsonPropertyName("stall_list")]
        public List<PosStallModel> StallList { get; set; }

        /// <summary>
        /// 菜品的状态
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 操作的类型，add新增 update更新 del删除
        /// </summary>
        [JsonPropertyName("sync_type")]
        public string SyncType { get; set; }

        /// <summary>
        /// 标签只支持那两种
        /// </summary>
        [JsonPropertyName("tags")]
        public string Tags { get; set; }

        /// <summary>
        /// 菜品类别single单品 packages套餐  除了删除，其他情况必传
        /// </summary>
        [JsonPropertyName("type_big")]
        public string TypeBig { get; set; }

        /// <summary>
        /// fixed固定套餐 choose 组合套餐  如果是套餐类型，这个必传，删除时候，可以不传
        /// </summary>
        [JsonPropertyName("type_small")]
        public string TypeSmall { get; set; }

        /// <summary>
        /// 菜品单位名称，除了删除，其他情况必传
        /// </summary>
        [JsonPropertyName("unit_name")]
        public string UnitName { get; set; }

        /// <summary>
        /// 更新时候的用户，更新，删除操作必传
        /// </summary>
        [JsonPropertyName("update_user")]
        public string UpdateUser { get; set; }
    }
}
