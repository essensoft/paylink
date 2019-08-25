using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniMultiAuditModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniMultiAuditModifyModel : AlipayObject
    {
        /// <summary>
        /// 审核备注
        /// </summary>
        [JsonProperty("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 处理动作agree/reject
        /// </summary>
        [JsonProperty("operate_result")]
        public string OperateResult { get; set; }

        /// <summary>
        /// 操作类型，高德固定填写AMAP_AUDIT_CALL_BACK
        /// </summary>
        [JsonProperty("operate_type")]
        public string OperateType { get; set; }

        /// <summary>
        /// 工单id
        /// </summary>
        [JsonProperty("task_id")]
        public string TaskId { get; set; }
    }
}
