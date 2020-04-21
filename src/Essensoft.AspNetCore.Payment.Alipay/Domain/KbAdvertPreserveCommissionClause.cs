using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbAdvertPreserveCommissionClause Data Structure.
    /// </summary>
    public class KbAdvertPreserveCommissionClause : AlipayObject
    {
        /// <summary>
        /// user_id：支付宝账户ID(2088开头)  logon_id：登陆账号
        /// </summary>
        [JsonPropertyName("claimer_id_type")]
        public string ClaimerIdType { get; set; }

        /// <summary>
        /// 认领人
        /// </summary>
        [JsonPropertyName("claimers")]
        public List<string> Claimers { get; set; }
    }
}
