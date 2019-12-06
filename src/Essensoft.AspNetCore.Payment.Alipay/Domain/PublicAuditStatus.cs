using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PublicAuditStatus Data Structure.
    /// </summary>
    public class PublicAuditStatus : AlipayObject
    {
        /// <summary>
        /// 审核状态描述，如果审核驳回则有相关的驳回理由
        /// </summary>
        [JsonPropertyName("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// AUDITING：审核中，AUDIT_FAILED：审核驳回，AUDIT_SUCCESS：审核通过，AUDIT_NORMAL：无审核记录
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// NAME:名称、AVATAR:头像、NAME_AVATAR:名称与头像、INTRODUCTION:简介
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
