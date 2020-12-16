using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbdishVirtualCatetorySimplifyInfo Data Structure.
    /// </summary>
    public class KbdishVirtualCatetorySimplifyInfo : AlipayObject
    {
        /// <summary>
        /// 虚拟类目的名称
        /// </summary>
        [JsonPropertyName("catetory_name")]
        public string CatetoryName { get; set; }

        /// <summary>
        /// 虚拟类目的排序值，需要保证为数字类型，如果不填默认为1
        /// </summary>
        [JsonPropertyName("catetory_sort")]
        public string CatetorySort { get; set; }

        /// <summary>
        /// 虚拟类目关联的菜品信息
        /// </summary>
        [JsonPropertyName("dish_list")]
        public List<KbdishVirtualDishSimplifyInfo> DishList { get; set; }

        /// <summary>
        /// 外部门店id的list
        /// </summary>
        [JsonPropertyName("out_shop_ids")]
        public List<string> OutShopIds { get; set; }

        /// <summary>
        /// forever/week，分别表示永久、按周，不传则只检查time_ranges字段
        /// </summary>
        [JsonPropertyName("period_type")]
        public string PeriodType { get; set; }

        /// <summary>
        /// 有效时间值，如果为forever则忽略，表示永久生效，如果为week，则传周几，逗号分隔，阿拉伯数字，1,2,5即表示周一、周二、周五生效
        /// </summary>
        [JsonPropertyName("period_value")]
        public string PeriodValue { get; set; }

        /// <summary>
        /// 菜品在菜谱中的售卖时间，同一个out_dish_id都指定的情况下，以第一个为准
        /// </summary>
        [JsonPropertyName("time_ranges")]
        public List<string> TimeRanges { get; set; }
    }
}
