using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringDishMenuSyncModel Data Structure.
    /// </summary>
    public class KoubeiCateringDishMenuSyncModel : AlipayObject
    {
        /// <summary>
        /// 菜谱背景图片id
        /// </summary>
        [JsonPropertyName("bg_image")]
        public string BgImage { get; set; }

        /// <summary>
        /// "CREATE_MENU"：创建菜单， "ADD_SHOP"：添加门店， "DELETE_SHOP"：删除门店， "ADD_DISH"：添加菜品， "DELETE_DISH"：删除菜品
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 菜谱类目列表
        /// </summary>
        [JsonPropertyName("category_list")]
        public List<KbdishCategorySimplifyInfo> CategoryList { get; set; }

        /// <summary>
        /// 菜单名称，需要保证pid下唯一，这个接口才生效
        /// </summary>
        [JsonPropertyName("cook_name")]
        public string CookName { get; set; }

        /// <summary>
        /// 时间区间日期结束
        /// </summary>
        [JsonPropertyName("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 时间区间截止 闭区间
        /// </summary>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 操作者id或名称
        /// </summary>
        [JsonPropertyName("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 外部门店id列表
        /// </summary>
        [JsonPropertyName("out_shop_id")]
        public List<string> OutShopId { get; set; }

        /// <summary>
        /// 时间约束类型 forever:永久; week:按周，每周周几 month:按月,每月几号
        /// </summary>
        [JsonPropertyName("period_type")]
        public string PeriodType { get; set; }

        /// <summary>
        /// 时间控制值,如果选的week, 值 1,2,3,4 ; 如果选择month，值 1,11; 如果选择永久，为空
        /// </summary>
        [JsonPropertyName("period_value")]
        public string PeriodValue { get; set; }

        /// <summary>
        /// 控制的日期区间开始
        /// </summary>
        [JsonPropertyName("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 时间控制 到分 闭区间
        /// </summary>
        [JsonPropertyName("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// open：启用 stop：停用
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
