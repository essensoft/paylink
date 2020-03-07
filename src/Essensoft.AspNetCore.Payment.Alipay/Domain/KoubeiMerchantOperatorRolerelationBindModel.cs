using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMerchantOperatorRolerelationBindModel Data Structure.
    /// </summary>
    public class KoubeiMerchantOperatorRolerelationBindModel : AlipayObject
    {
        /// <summary>
        /// 服务商、服务商员工、商户、商户员工等口碑角色操作时必填，对应为《koubei.member.data.oauth.query》中的auth_code，默认有效期24小时；isv自身角色操作的时候，无需传该参数
        /// </summary>
        [JsonPropertyName("auth_code")]
        public string AuthCode { get; set; }

        /// <summary>
        /// 操作员id列表
        /// </summary>
        [JsonPropertyName("operator_ids")]
        public List<string> OperatorIds { get; set; }

        /// <summary>
        /// 角色id
        /// </summary>
        [JsonPropertyName("role_id")]
        public string RoleId { get; set; }
    }
}
