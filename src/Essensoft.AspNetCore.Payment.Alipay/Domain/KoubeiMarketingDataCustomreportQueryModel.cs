using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingDataCustomreportQueryModel Data Structure.
    /// </summary>
    public class KoubeiMarketingDataCustomreportQueryModel : AlipayObject
    {
        /// <summary>
        /// 规则KEY
        /// </summary>
        [JsonPropertyName("condition_key")]
        public string ConditionKey { get; set; }

        /// <summary>
        /// 额外增加的查询过滤条件
        /// </summary>
        [JsonPropertyName("filter_tags")]
        public List<FilterTag> FilterTags { get; set; }

        /// <summary>
        /// 一次拉多少条
        /// </summary>
        [JsonPropertyName("max_count")]
        public string MaxCount { get; set; }
    }
}
