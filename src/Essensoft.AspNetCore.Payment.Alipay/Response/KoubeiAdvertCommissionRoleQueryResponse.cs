using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiAdvertCommissionRoleQueryResponse.
    /// </summary>
    public class KoubeiAdvertCommissionRoleQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 角色拥有信息，无论是否拥有角色，都会返回“角色拥有信息”，如果没有，则返回没有开通。同时需要通过role_code ，查找对应角色的开通情况
        /// </summary>
        [JsonPropertyName("role_infos")]
        public List<KbadvertRoleInfoResponse> RoleInfos { get; set; }
    }
}
