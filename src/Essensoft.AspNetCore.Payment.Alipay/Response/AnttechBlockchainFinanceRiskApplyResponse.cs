using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AnttechBlockchainFinanceRiskApplyResponse.
    /// </summary>
    public class AnttechBlockchainFinanceRiskApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 外部风控编号
        /// </summary>
        [JsonPropertyName("out_risk_id")]
        public string OutRiskId { get; set; }

        /// <summary>
        /// 风控申请结果返回
        /// </summary>
        [JsonPropertyName("risk_info")]
        public string RiskInfo { get; set; }
    }
}
