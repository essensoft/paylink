using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceAntestAlipayversionQueryResponse.
    /// </summary>
    public class AlipayCommerceAntestAlipayversionQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝版本
        /// </summary>
        [JsonPropertyName("data")]
        public List<string> Data { get; set; }
    }
}
