using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// RiskConfig Data Structure.
    /// </summary>
    public class RiskConfig : AlipayObject
    {
        /// <summary>
        /// 类目风控信息列表，为必传字段。此字段为复杂模型，其中类目code为必传属性。
        /// </summary>
        [JsonPropertyName("category_risks")]
        public List<CategoryRiskInfo> CategoryRisks { get; set; }

        /// <summary>
        /// 全局分段限额配置
        /// </summary>
        [JsonPropertyName("quota_gradient_rule")]
        public QuotaGradientRule QuotaGradientRule { get; set; }
    }
}
