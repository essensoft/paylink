using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMerchantRoleDetailQueryModel Data Structure.
    /// </summary>
    public class KoubeiMerchantRoleDetailQueryModel : AlipayObject
    {
        /// <summary>
        /// isv回传的auth_code，通过auth_code校验当前操作人与商户的关系
        /// </summary>
        [JsonPropertyName("auth_code")]
        public string AuthCode { get; set; }

        /// <summary>
        /// 角色id
        /// </summary>
        [JsonPropertyName("role_id")]
        public string RoleId { get; set; }
    }
}
