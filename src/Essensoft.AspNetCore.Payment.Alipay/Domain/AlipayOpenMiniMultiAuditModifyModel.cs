using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniMultiAuditModifyModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniMultiAuditModifyModel : AlipayObject
    {
        /// <summary>
        /// 审核备注
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 处理动作agree/reject
        /// </summary>
        [JsonPropertyName("operate_result")]
        public string OperateResult { get; set; }

        /// <summary>
        /// 操作类型，高德固定填写AMAP_AUDIT_CALL_BACK
        /// </summary>
        [JsonPropertyName("operate_type")]
        public string OperateType { get; set; }

        /// <summary>
        /// 工单id
        /// </summary>
        [JsonPropertyName("task_id")]
        public string TaskId { get; set; }
    }
}
