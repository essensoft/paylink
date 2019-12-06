using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// QueryGroup Data Structure.
    /// </summary>
    public class QueryGroup : AlipayObject
    {
        /// <summary>
        /// 分组id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 分组中的圈人规则
        /// </summary>
        [JsonPropertyName("label_rule")]
        public List<QueryComplexLabelRule> LabelRule { get; set; }

        /// <summary>
        /// 用户分组名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
