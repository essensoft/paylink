using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenPublicInfoModifyResponse.
    /// </summary>
    public class AlipayOpenPublicInfoModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 服务窗审核状态描述
        /// </summary>
        [JsonPropertyName("audit_desc")]
        public string AuditDesc { get; set; }

        /// <summary>
        /// 服务窗审核状态，申请成功后返回AUDITING，等待风控审核
        /// </summary>
        [JsonPropertyName("audit_status")]
        public string AuditStatus { get; set; }
    }
}
