using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AliTrustRiskIdentify Data Structure.
    /// </summary>
    public class AliTrustRiskIdentify : AlipayObject
    {
        /// <summary>
        /// 芝麻信用风险名单详情列表
        /// </summary>
        [JsonPropertyName("details")]
        public List<ZhimaRiskDetail> Details { get; set; }

        /// <summary>
        /// 当有风险时,为"T";无风险识别是为"F"
        /// </summary>
        [JsonPropertyName("is_risk")]
        public string IsRisk { get; set; }

        /// <summary>
        /// 已废弃
        /// </summary>
        [JsonPropertyName("risk_tag")]
        public string RiskTag { get; set; }
    }
}
