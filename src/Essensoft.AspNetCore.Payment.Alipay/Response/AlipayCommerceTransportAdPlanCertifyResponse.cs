using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceTransportAdPlanCertifyResponse.
    /// </summary>
    public class AlipayCommerceTransportAdPlanCertifyResponse : AlipayResponse
    {
        /// <summary>
        /// 返回结果  true: 成功  false: 失败
        /// </summary>
        [JsonPropertyName("audit_result")]
        public bool AuditResult { get; set; }

        /// <summary>
        /// BIZ_ERROR中业务错误对应的文案描述
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; }
    }
}
