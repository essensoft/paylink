using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbdishGroupSimplifyInfo Data Structure.
    /// </summary>
    public class KbdishGroupSimplifyInfo : AlipayObject
    {
        /// <summary>
        /// 套餐组上的活动信息，属isv外部活动信息
        /// </summary>
        [JsonPropertyName("activity_info")]
        public string ActivityInfo { get; set; }

        /// <summary>
        /// 套餐组明细
        /// </summary>
        [JsonPropertyName("group_detail_list")]
        public List<KbdishGroupDetailSimplifyInfo> GroupDetailList { get; set; }

        /// <summary>
        /// 套餐组规则，fix：是否固定套餐，true：是；false：不是。max_count：最大可选数量；min_count：最小可选数量。sort：套餐组排序值数字从小到大排
        /// </summary>
        [JsonPropertyName("group_rule")]
        public string GroupRule { get; set; }

        /// <summary>
        /// 套餐组名称，固定组可不传
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
