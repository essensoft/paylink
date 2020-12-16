using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayBossFncGfacceptanceBillAcceptResponse.
    /// </summary>
    public class AlipayBossFncGfacceptanceBillAcceptResponse : AlipayResponse
    {
        /// <summary>
        /// 业财受理结果
        /// </summary>
        [JsonPropertyName("result")]
        public GFAOpenAPIAcceptanceResult Result { get; set; }
    }
}
