using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniResourceCreateModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniResourceCreateModel : AlipayObject
    {
        /// <summary>
        /// 流量位的计费模式，目前可选择值为：CPS、CPC，根据自己的业务模式选择合适的计费模式。
        /// </summary>
        [JsonPropertyName("mode")]
        public string Mode { get; set; }

        /// <summary>
        /// 流量位的名称，同一个小程序下最多创建50(含)个流量位，并且同一个小程序下的流量位名称不能重复。
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 展示列数，可选值为：1、2
        /// </summary>
        [JsonPropertyName("row_num")]
        public long RowNum { get; set; }

        /// <summary>
        /// 流量位规则列表，一个流量位最多关联5个规则
        /// </summary>
        [JsonPropertyName("rule_list")]
        public List<MiniResourceRule> RuleList { get; set; }

        /// <summary>
        /// 商品展示个数，可选值为：0-200的正整数
        /// </summary>
        [JsonPropertyName("show_num")]
        public long ShowNum { get; set; }

        /// <summary>
        /// 流量位展示类型。 INFORMATION 信息流；
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
