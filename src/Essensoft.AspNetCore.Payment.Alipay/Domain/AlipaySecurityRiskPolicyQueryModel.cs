using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityRiskPolicyQueryModel Data Structure.
    /// </summary>
    public class AlipaySecurityRiskPolicyQueryModel : AlipayObject
    {
        /// <summary>
        /// 风险类型：表示风险处理或风险咨询——process/advice
        /// </summary>
        [JsonPropertyName("risk_type")]
        public string RiskType { get; set; }

        /// <summary>
        /// 安全场景参数
        /// </summary>
        [JsonPropertyName("security_scene")]
        public SecurityScene SecurityScene { get; set; }

        /// <summary>
        /// 服务上下文包括环境信息和用户信息
        /// </summary>
        [JsonPropertyName("service_context")]
        public ServiceContext ServiceContext { get; set; }
    }
}
