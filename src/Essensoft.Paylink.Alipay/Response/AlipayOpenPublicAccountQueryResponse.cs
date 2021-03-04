using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenPublicAccountQueryResponse.
    /// </summary>
    public class AlipayOpenPublicAccountQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 绑定账户列表
        /// </summary>
        [JsonPropertyName("public_bind_accounts")]
        public List<StdPublicBindAccount> PublicBindAccounts { get; set; }
    }
}
