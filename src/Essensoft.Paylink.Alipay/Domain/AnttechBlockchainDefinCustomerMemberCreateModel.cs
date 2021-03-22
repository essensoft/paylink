using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AnttechBlockchainDefinCustomerMemberCreateModel Data Structure.
    /// </summary>
    public class AnttechBlockchainDefinCustomerMemberCreateModel : AlipayObject
    {
        /// <summary>
        /// 认证方式（NONE:不认证）
        /// </summary>
        [JsonPropertyName("auth_type")]
        public string AuthType { get; set; }

        /// <summary>
        /// 业务线（LOGISTICS_FIN-物流金融，SHIPPING_EBL-电子提单）
        /// </summary>
        [JsonPropertyName("biz_product")]
        public string BizProduct { get; set; }

        /// <summary>
        /// 企业相关数据
        /// </summary>
        [JsonPropertyName("company_info")]
        public DefiCustCompanyDTO CompanyInfo { get; set; }

        /// <summary>
        /// did
        /// </summary>
        [JsonPropertyName("did")]
        public string Did { get; set; }

        /// <summary>
        /// 会员类型（ENTERPRISE-企业，INDIVIDUAL-个人）
        /// </summary>
        [JsonPropertyName("member_type")]
        public string MemberType { get; set; }

        /// <summary>
        /// 角色列表
        /// </summary>
        [JsonPropertyName("role_types")]
        public List<string> RoleTypes { get; set; }

        /// <summary>
        /// 商业中台租户ID
        /// </summary>
        [JsonPropertyName("tenant_id")]
        public string TenantId { get; set; }
    }
}
