using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayInsUnderwritePolicyQueryResponse.
    /// </summary>
    public class AlipayInsUnderwritePolicyQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 保单
        /// </summary>
        [JsonPropertyName("policy")]
        public InsPolicy Policy { get; set; }
    }
}
