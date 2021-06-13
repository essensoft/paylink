using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniResourceModifyModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniResourceModifyModel : AlipayObject
    {
        /// <summary>
        /// 流量位的名称，用于标识区分不用的流量位，最长32个字符，一个中文算两个字符。不传则不更新。同一个小程序下的流量位名称不能重复。
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 流量位创建接口返回的流量位id，注意不是流量位来源的id。
        /// </summary>
        [JsonPropertyName("resource_id")]
        public string ResourceId { get; set; }

        /// <summary>
        /// 展示列数，可选值为：1、2
        /// </summary>
        [JsonPropertyName("row_num")]
        public long RowNum { get; set; }

        /// <summary>
        /// 需要修改的规则列表，不传不则不修改
        /// </summary>
        [JsonPropertyName("rule_list")]
        public List<MiniResourceRule> RuleList { get; set; }

        /// <summary>
        /// 商品展示个数，可选值为：0-200的正整数
        /// </summary>
        [JsonPropertyName("show_num")]
        public long ShowNum { get; set; }
    }
}
