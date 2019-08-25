using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMerchantRoleDetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMerchantRoleDetailQueryModel : AlipayObject
    {
        /// <summary>
        /// isv回传的auth_code，通过auth_code校验当前操作人与商户的关系
        /// </summary>
        [JsonProperty("auth_code")]
        public string AuthCode { get; set; }

        /// <summary>
        /// 角色id
        /// </summary>
        [JsonProperty("role_id")]
        public string RoleId { get; set; }
    }
}
