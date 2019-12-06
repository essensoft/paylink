using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityRiskPolicyRdsQueryModel Data Structure.
    /// </summary>
    public class AlipaySecurityRiskPolicyRdsQueryModel : AlipayObject
    {
        /// <summary>
        /// 参数名称：RDS采集的行为数据；非唯一；参数作用：RDS系统通过行为数据做人机识别；如何获取：客户端集成RDS的SDK后自动会获取到该数据。
        /// </summary>
        [JsonPropertyName("rds_params")]
        public string RdsParams { get; set; }
    }
}
