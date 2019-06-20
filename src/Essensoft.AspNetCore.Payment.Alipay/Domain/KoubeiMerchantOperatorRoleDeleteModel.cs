using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMerchantOperatorRoleDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMerchantOperatorRoleDeleteModel : AlipayObject
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
    }
}
