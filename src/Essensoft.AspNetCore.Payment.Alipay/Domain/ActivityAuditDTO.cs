using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ActivityAuditDTO Data Structure.
    /// </summary>
    public class ActivityAuditDTO : AlipayObject
    {
        /// <summary>
        /// 审核id
        /// </summary>
        [JsonPropertyName("audit_id")]
        public string AuditId { get; set; }

        /// <summary>
        /// INIT:初始化;AUDITING:审核中;REJECT:审核驳回;PASS:审核通过;CANCEL:审核撤销;FAIL:审核失败
        /// </summary>
        [JsonPropertyName("audit_status")]
        public string AuditStatus { get; set; }

        /// <summary>
        /// 操作人id
        /// </summary>
        [JsonPropertyName("creator_id")]
        public string CreatorId { get; set; }

        /// <summary>
        /// SALES:口碑内部小二;PROVIDER:外部服务商;PROVIDER_STAFF:外部服务商员工
        /// </summary>
        [JsonPropertyName("creator_type")]
        public string CreatorType { get; set; }

        /// <summary>
        /// 操作时间
        /// </summary>
        [JsonPropertyName("operation_time")]
        public string OperationTime { get; set; }

        /// <summary>
        /// 审核通过或者审核驳回的原因
        /// </summary>
        [JsonPropertyName("reason")]
        public string Reason { get; set; }
    }
}
