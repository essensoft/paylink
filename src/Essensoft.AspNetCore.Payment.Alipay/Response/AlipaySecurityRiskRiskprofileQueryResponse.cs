using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySecurityRiskRiskprofileQueryResponse.
    /// </summary>
    public class AlipaySecurityRiskRiskprofileQueryResponse : AlipayResponse
    {
        /// <summary>
        /// success 字段为false 是返回失败原因
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; }

        /// <summary>
        /// riskprofile查询返回的键值对
        /// </summary>
        [JsonPropertyName("risk_profile_value")]
        public List<RiskProfileDto> RiskProfileValue { get; set; }

        /// <summary>
        /// 处理结果，true：处理成功，false:处理失败
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
