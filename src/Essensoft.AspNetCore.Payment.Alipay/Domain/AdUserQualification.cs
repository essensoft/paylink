using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AdUserQualification Data Structure.
    /// </summary>
    [Serializable]
    public class AdUserQualification : AlipayObject
    {
        /// <summary>
        /// 审核人员id
        /// </summary>
        [JsonProperty("approver")]
        public string Approver { get; set; }

        /// <summary>
        /// 审核原因
        /// </summary>
        [JsonProperty("audit_reason")]
        public string AuditReason { get; set; }

        /// <summary>
        /// 审核状态：0 审核通过、1 库存校验中、2运营审核中、3 审核拒绝
        /// </summary>
        [JsonProperty("audit_status")]
        public long AuditStatus { get; set; }

        /// <summary>
        /// 审核日期
        /// </summary>
        [JsonProperty("audit_time")]
        public long AuditTime { get; set; }

        /// <summary>
        /// 资质文件列表
        /// </summary>
        [JsonProperty("file_url")]
        public List<string> FileUrl { get; set; }

        /// <summary>
        /// 资质id
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// 资质名称
        /// </summary>
        [JsonProperty("qualification_name")]
        public string QualificationName { get; set; }
    }
}
