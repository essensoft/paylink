using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySecurityRiskCustomerriskQueryResponse.
    /// </summary>
    public class AlipaySecurityRiskCustomerriskQueryResponse : AlipayResponse
    {
        /// <summary>
        /// risk_result:风险分析结果，主要有三种类型，分别为是否有风险（has_risk,no_risk)，风险等级（"rank_1"...,"rank_10")，归一化的风险评分（0-100），每一次返回，根据配置的不同，可以返回样的风险类型，也可以返回不同的风险结果类型
        /// </summary>
        [JsonPropertyName("risk_result")]
        public string RiskResult { get; set; }

        /// <summary>
        /// risk_result_desc:风险结果的返回值描述，因为每次返回值不一样，因此需要给出返回值说明，避免接入方维护这种对应关系
        /// </summary>
        [JsonPropertyName("risk_result_desc")]
        public string RiskResultDesc { get; set; }
    }
}
