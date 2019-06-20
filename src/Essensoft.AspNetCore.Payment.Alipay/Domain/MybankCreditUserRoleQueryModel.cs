using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankCreditUserRoleQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditUserRoleQueryModel : AlipayObject
    {
        /// <summary>
        /// 站点会员信息
        /// </summary>
        [JsonProperty("member")]
        public Member Member { get; set; }
    }
}
