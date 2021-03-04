using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// KoubeiAdvertCommissionAdvertQueryResponse.
    /// </summary>
    public class KoubeiAdvertCommissionAdvertQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 推广详情集合
        /// </summary>
        [JsonPropertyName("data")]
        public List<KbAdvertAdvResponse> Data { get; set; }
    }
}
