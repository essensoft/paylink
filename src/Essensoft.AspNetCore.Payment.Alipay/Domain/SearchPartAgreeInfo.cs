using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SearchPartAgreeInfo Data Structure.
    /// </summary>
    public class SearchPartAgreeInfo : AlipayObject
    {
        /// <summary>
        /// 剔除数据名称
        /// </summary>
        [JsonPropertyName("audit_info")]
        public string AuditInfo { get; set; }

        /// <summary>
        /// 剔除数据的operator信息
        /// </summary>
        [JsonPropertyName("audit_operator")]
        public string AuditOperator { get; set; }

        /// <summary>
        /// 剔除原因
        /// </summary>
        [JsonPropertyName("audit_reason")]
        public string AuditReason { get; set; }

        /// <summary>
        /// 剔除数据类型
        /// </summary>
        [JsonPropertyName("audit_type")]
        public string AuditType { get; set; }
    }
}
