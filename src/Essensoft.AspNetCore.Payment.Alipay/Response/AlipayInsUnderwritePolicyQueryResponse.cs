using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
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
