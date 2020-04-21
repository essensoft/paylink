using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiShopMallAuditQueryResponse.
    /// </summary>
    public class KoubeiShopMallAuditQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 审核备注
        /// </summary>
        [JsonPropertyName("audit_remark")]
        public string AuditRemark { get; set; }

        /// <summary>
        /// 工单审核状态：AUDITING 审核中，SUCCESS 通过，REJECTED 拒绝
        /// </summary>
        [JsonPropertyName("audit_status")]
        public string AuditStatus { get; set; }
    }
}
