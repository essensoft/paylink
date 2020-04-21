using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMerchantRoleDetailQueryResponse.
    /// </summary>
    public class KoubeiMerchantRoleDetailQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 根据主体查询到的主体拥有的角色信息
        /// </summary>
        [JsonPropertyName("permissions")]
        public List<BusinessPermission> Permissions { get; set; }

        /// <summary>
        /// 角色码
        /// </summary>
        [JsonPropertyName("role_code")]
        public string RoleCode { get; set; }

        /// <summary>
        /// 人员管理场景角色id
        /// </summary>
        [JsonPropertyName("role_id")]
        public string RoleId { get; set; }

        /// <summary>
        /// 人员管理场景角色名称
        /// </summary>
        [JsonPropertyName("role_name")]
        public string RoleName { get; set; }
    }
}
