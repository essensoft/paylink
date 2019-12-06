using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CustomReportCondition Data Structure.
    /// </summary>
    public class CustomReportCondition : AlipayObject
    {
        /// <summary>
        /// 规则KEY-为空则为创建规则，否则更新规则
        /// </summary>
        [JsonPropertyName("condition_key")]
        public string ConditionKey { get; set; }

        /// <summary>
        /// 明细数据标签
        /// </summary>
        [JsonPropertyName("data_tags")]
        public List<DataTag> DataTags { get; set; }

        /// <summary>
        /// 分组过滤条件
        /// </summary>
        [JsonPropertyName("filter_tags")]
        public List<FilterTag> FilterTags { get; set; }

        /// <summary>
        /// 分组数据标签集合  注意：这个是JSON数组，必须以[开头，以]结尾，[]外层不能加双引号"",正确案例["orpt_ubase_age","orpt_ubase_birthday_mm"]，错误案例："["orpt_ubase_age","orpt_ubase_birthday_mm"]"
        /// </summary>
        [JsonPropertyName("group_tags")]
        public string GroupTags { get; set; }

        /// <summary>
        /// 规则描述
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 自定义报表名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 排序数据标签集合  注意：这个是JSON数组，必须以[开头，以]结尾，[]外层不能加双引号"",正确案例[{"code":"orpt_ubase_age","sortBy":"DESC"}]，错误案例："[{"code":"orpt_ubase_age","sortBy":"DESC"}]"
        /// </summary>
        [JsonPropertyName("sort_tags")]
        public string SortTags { get; set; }
    }
}
