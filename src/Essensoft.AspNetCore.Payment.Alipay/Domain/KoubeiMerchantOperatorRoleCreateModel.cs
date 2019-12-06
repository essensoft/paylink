using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMerchantOperatorRoleCreateModel Data Structure.
    /// </summary>
    public class KoubeiMerchantOperatorRoleCreateModel : AlipayObject
    {
        /// <summary>
        /// 操作员ID
        /// </summary>
        [JsonPropertyName("auth_code")]
        public string AuthCode { get; set; }

        /// <summary>
        /// 角色ID
        /// </summary>
        [JsonPropertyName("role_id")]
        public string RoleId { get; set; }

        /// <summary>
        /// 角色名称，修改时必填
        /// </summary>
        [JsonPropertyName("role_name")]
        public string RoleName { get; set; }
    }
}
