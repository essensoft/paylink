using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMerchantOperatorRoleQueryModel Data Structure.
    /// </summary>
    public class KoubeiMerchantOperatorRoleQueryModel : AlipayObject
    {
        /// <summary>
        /// 当前操作员ID
        /// </summary>
        [JsonPropertyName("auth_code")]
        public string AuthCode { get; set; }

        /// <summary>
        /// 角色ID,若传入刚查对应角色ID的信息
        /// </summary>
        [JsonPropertyName("role_id")]
        public string RoleId { get; set; }
    }
}
