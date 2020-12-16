using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySecurityRiskPolicyRdsQueryResponse.
    /// </summary>
    public class AlipaySecurityRiskPolicyRdsQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 人机识别结果。返回HUMAN表示识别结果为人；返回ROBOT表示识别结果为机器。只有返回ROBOT时，业务才执行拦截动作，其它返回值均不做拦截。
        /// </summary>
        [JsonPropertyName("rds_result")]
        public string RdsResult { get; set; }
    }
}
