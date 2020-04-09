using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AnttechBlockchainFinanceRiskWarningAddModel Data Structure.
    /// </summary>
    public class AnttechBlockchainFinanceRiskWarningAddModel : AlipayObject
    {
        /// <summary>
        /// 外部风控编号
        /// </summary>
        [JsonPropertyName("out_risk_id")]
        public string OutRiskId { get; set; }

        /// <summary>
        /// 风控详情
        /// </summary>
        [JsonPropertyName("risk_info")]
        public string RiskInfo { get; set; }
    }
}
