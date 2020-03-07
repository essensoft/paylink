using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMerchantRolePermissionCreateModel Data Structure.
    /// </summary>
    public class KoubeiMerchantRolePermissionCreateModel : AlipayObject
    {
        /// <summary>
        /// isv回传的auth_code，通过auth_code校验当前操作人与商户的关系
        /// </summary>
        [JsonPropertyName("auth_code")]
        public string AuthCode { get; set; }

        /// <summary>
        /// 需要增加的isv权限
        /// </summary>
        [JsonPropertyName("permissions_to_add")]
        public List<BusinessPermission> PermissionsToAdd { get; set; }

        /// <summary>
        /// 需要删除的权限
        /// </summary>
        [JsonPropertyName("permissions_to_delete")]
        public List<BusinessPermission> PermissionsToDelete { get; set; }

        /// <summary>
        /// 与principal_type配合使用，当principal_type为ROLE时，principal_id为角色id，当principal_type为OPERATOR时，principal_id为操作员id
        /// </summary>
        [JsonPropertyName("principal_id")]
        public string PrincipalId { get; set; }

        /// <summary>
        /// 与principal_id配合使用，当principal_type为ROLE时，principal_id为角色id，当principal_type为OPERATOR时，principal_id为操作员id
        /// </summary>
        [JsonPropertyName("principal_type")]
        public string PrincipalType { get; set; }
    }
}
