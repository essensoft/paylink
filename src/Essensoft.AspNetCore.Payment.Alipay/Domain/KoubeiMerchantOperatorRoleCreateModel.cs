using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMerchantOperatorRoleCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMerchantOperatorRoleCreateModel : AlipayObject
    {
        /// <summary>
        /// 操作员ID
        /// </summary>
        [JsonProperty("auth_code")]
        public string AuthCode { get; set; }

        /// <summary>
        /// 角色ID
        /// </summary>
        [JsonProperty("role_id")]
        public string RoleId { get; set; }

        /// <summary>
        /// 角色名称，修改时必填
        /// </summary>
        [JsonProperty("role_name")]
        public string RoleName { get; set; }
    }
}
