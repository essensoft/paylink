using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// ZolozIdentificationCustomerIdcardCertifyResponse.
    /// </summary>
    public class ZolozIdentificationCustomerIdcardCertifyResponse : AlipayResponse
    {
        /// <summary>
        /// 证件宝审核结果
        /// </summary>
        [JsonPropertyName("cert_audit_result")]
        public List<CertAuditResult> CertAuditResult { get; set; }

        /// <summary>
        /// 业务校验是否通过
        /// </summary>
        [JsonPropertyName("passed")]
        public bool Passed { get; set; }

        /// <summary>
        /// 全流程上下文唯一id
        /// </summary>
        [JsonPropertyName("token")]
        public string Token { get; set; }
    }
}
