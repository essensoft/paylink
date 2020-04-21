using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// SsdataDataserviceRiskContentVerifyResponse.
    /// </summary>
    public class SsdataDataserviceRiskContentVerifyResponse : AlipayResponse
    {
        /// <summary>
        /// 对应传入的每一种风险类型的所有风险识别结果
        /// </summary>
        [JsonPropertyName("risk_result")]
        public List<RiskResult> RiskResult { get; set; }

        /// <summary>
        /// 分值
        /// </summary>
        [JsonPropertyName("score")]
        public string Score { get; set; }

        /// <summary>
        /// 业务唯一识别码
        /// </summary>
        [JsonPropertyName("unique_id")]
        public string UniqueId { get; set; }
    }
}
