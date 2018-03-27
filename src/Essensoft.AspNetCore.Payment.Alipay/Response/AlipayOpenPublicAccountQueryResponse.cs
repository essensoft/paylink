using Newtonsoft.Json;
using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenPublicAccountQueryResponse.
    /// </summary>
    public class AlipayOpenPublicAccountQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 绑定账户列表
        /// </summary>
        [JsonProperty("public_bind_accounts")]
        public List<StdPublicBindAccount> PublicBindAccounts { get; set; }
    }
}
