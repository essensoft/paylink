using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityRiskPolicyRdsQueryModel Data Structure.
    /// </summary>
    public class AlipaySecurityRiskPolicyRdsQueryModel : AlipayObject
    {
        /// <summary>
        /// 具体需传递的参数请参考接入文档中的参数列表 https://yuque.antfin-inc.com/tecsec/rds/insertdoc
        /// </summary>
        [JsonPropertyName("rds_params")]
        public string RdsParams { get; set; }
    }
}
