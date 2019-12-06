using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySecurityProdFingerprintRiskcontrolQueryResponse.
    /// </summary>
    public class AlipaySecurityProdFingerprintRiskcontrolQueryResponse : AlipayResponse
    {
        /// <summary>
        /// IFAA服务端查询结果，true为支持指纹功能，false为不支持
        /// </summary>
        [JsonPropertyName("check_result")]
        public bool CheckResult { get; set; }
    }
}
