using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMerchantRole Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMerchantRole : AlipayObject
    {
        /// <summary>
        /// 员工数量
        /// </summary>
        [JsonProperty("operator_num")]
        public string OperatorNum { get; set; }

        /// <summary>
        /// 权限数量
        /// </summary>
        [JsonProperty("permission_num")]
        public string PermissionNum { get; set; }

        /// <summary>
        /// 角色标识码，如财务
        /// </summary>
        [JsonProperty("role_code")]
        public string RoleCode { get; set; }

        /// <summary>
        /// 角色ID
        /// </summary>
        [JsonProperty("role_id")]
        public string RoleId { get; set; }

        /// <summary>
        /// 角色名称
        /// </summary>
        [JsonProperty("role_name")]
        public string RoleName { get; set; }
    }
}
