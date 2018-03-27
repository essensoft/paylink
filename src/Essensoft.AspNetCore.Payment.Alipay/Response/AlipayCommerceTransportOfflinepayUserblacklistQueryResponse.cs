using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceTransportOfflinepayUserblacklistQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportOfflinepayUserblacklistQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 黑名单用户ID
        /// </summary>
        [JsonProperty("black_list")]
        public List<string> BlackList { get; set; }
    }
}
