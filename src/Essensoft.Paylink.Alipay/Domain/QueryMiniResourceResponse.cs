using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// QueryMiniResourceResponse Data Structure.
    /// </summary>
    public class QueryMiniResourceResponse : AlipayObject
    {
        /// <summary>
        /// 端
        /// </summary>
        [JsonPropertyName("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 流量位模式 CPS
        /// </summary>
        [JsonPropertyName("mode")]
        public string Mode { get; set; }

        /// <summary>
        /// 流量位名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 流量位id
        /// </summary>
        [JsonPropertyName("resource_id")]
        public string ResourceId { get; set; }

        /// <summary>
        /// 广告展示列数
        /// </summary>
        [JsonPropertyName("row_num")]
        public string RowNum { get; set; }

        /// <summary>
        /// 流量位规则列表
        /// </summary>
        [JsonPropertyName("rule_list")]
        public List<MiniResourceRule> RuleList { get; set; }

        /// <summary>
        /// 广告展示个数
        /// </summary>
        [JsonPropertyName("show_num")]
        public string ShowNum { get; set; }

        /// <summary>
        /// 流量位类型 INFORMATION: 信息流
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
