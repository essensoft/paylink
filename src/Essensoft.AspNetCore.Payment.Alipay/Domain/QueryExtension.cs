using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// QueryExtension Data Structure.
    /// </summary>
    public class QueryExtension : AlipayObject
    {
        /// <summary>
        /// 扩展区列表
        /// </summary>
        [JsonProperty("areas")]
        public List<ExtensionArea> Areas { get; set; }

        /// <summary>
        /// 扩展区套id
        /// </summary>
        [JsonProperty("extension_key")]
        public string ExtensionKey { get; set; }

        /// <summary>
        /// 标签规则列表
        /// </summary>
        [JsonProperty("label_rules")]
        public List<QueryLabelRule> LabelRules { get; set; }

        /// <summary>
        /// 扩展区状态，"ON"代表上线，"OFF"代表下线，只有上线的扩展区才能被用户看到
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
