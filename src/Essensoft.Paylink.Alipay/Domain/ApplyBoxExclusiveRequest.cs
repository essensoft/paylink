using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ApplyBoxExclusiveRequest Data Structure.
    /// </summary>
    public class ApplyBoxExclusiveRequest : AlipayObject
    {
        /// <summary>
        /// 品牌box基础模型
        /// </summary>
        [JsonPropertyName("base_info")]
        public BoxExclusiveBase BaseInfo { get; set; }

        /// <summary>
        /// 品牌id
        /// </summary>
        [JsonPropertyName("brand_id")]
        public string BrandId { get; set; }

        /// <summary>
        /// 默认品牌触发词
        /// </summary>
        [JsonPropertyName("default_keywords")]
        public List<string> DefaultKeywords { get; set; }

        /// <summary>
        /// 工单id
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 自定义品牌触发词
        /// </summary>
        [JsonPropertyName("keywords")]
        public List<string> Keywords { get; set; }

        /// <summary>
        /// 操作人id
        /// </summary>
        [JsonPropertyName("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// box官方账号
        /// </summary>
        [JsonPropertyName("related_accounts")]
        public List<BoxExclusiveService> RelatedAccounts { get; set; }

        /// <summary>
        /// box服务模型
        /// </summary>
        [JsonPropertyName("related_functions")]
        public List<BoxExclusiveService> RelatedFunctions { get; set; }
    }
}
