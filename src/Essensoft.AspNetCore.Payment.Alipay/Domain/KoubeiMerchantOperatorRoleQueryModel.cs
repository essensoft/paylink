using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMerchantOperatorRoleQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMerchantOperatorRoleQueryModel : AlipayObject
    {
        /// <summary>
        /// 当前操作员ID
        /// </summary>
        [JsonProperty("auth_code")]
        public string AuthCode { get; set; }

        /// <summary>
        /// 角色ID,若传入刚查对应角色ID的信息
        /// </summary>
        [JsonProperty("role_id")]
        public string RoleId { get; set; }
    }
}
