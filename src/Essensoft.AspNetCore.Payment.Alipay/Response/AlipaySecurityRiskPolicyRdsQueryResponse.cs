using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySecurityRiskPolicyRdsQueryResponse.
    /// </summary>
    public class AlipaySecurityRiskPolicyRdsQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 人机识别结果。返回HUMAN表示识别结果为人；返回ROBOT表示识别结果为机器。
        /// </summary>
        [JsonPropertyName("rds_result")]
        public string RdsResult { get; set; }
    }
}
