using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DefiCustMemberDTO Data Structure.
    /// </summary>
    public class DefiCustMemberDTO : AlipayObject
    {
        /// <summary>
        /// 企业认证状态 INIT("INIT", "初始状态"), AUTH("AUTH", "认证状态"),;
        /// </summary>
        [JsonPropertyName("auth_status")]
        public string AuthStatus { get; set; }

        /// <summary>
        /// 统一社会信用代码或者工商注册号
        /// </summary>
        [JsonPropertyName("company_cert_no")]
        public string CompanyCertNo { get; set; }

        /// <summary>
        /// NATIONAL_LEGAL_MERGE("2011", " NATIONAL_LEGAL_MERGE", "全国法人营业执照(多证合一)", "全国法人营业执照(多证合一)"), NATIONAL_LEGAL("201", "NATIONAL_LEGAL", "全国法人营业执照", "全国法人营业执照"),
        /// </summary>
        [JsonPropertyName("company_cert_type")]
        public string CompanyCertType { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        [JsonPropertyName("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// ID映射
        /// </summary>
        [JsonPropertyName("id_map")]
        public string IdMap { get; set; }

        /// <summary>
        /// 企业邮箱
        /// </summary>
        [JsonPropertyName("member_email")]
        public string MemberEmail { get; set; }

        /// <summary>
        /// 会员id
        /// </summary>
        [JsonPropertyName("member_id")]
        public string MemberId { get; set; }

        /// <summary>
        /// 角色，支持多角色
        /// </summary>
        [JsonPropertyName("role_types")]
        public List<string> RoleTypes { get; set; }

        /// <summary>
        /// ACTIVE("ACTIVE", "激活状态"), FROZEN("FROZEN", "冻结状态"), DISABLED("DISABLED", "禁用状态"),;
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
