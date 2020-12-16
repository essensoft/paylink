using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceAntestAppversionQueryResponse.
    /// </summary>
    public class AlipayCommerceAntestAppversionQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 版本号
        /// </summary>
        [JsonPropertyName("data")]
        public List<string> Data { get; set; }
    }
}
