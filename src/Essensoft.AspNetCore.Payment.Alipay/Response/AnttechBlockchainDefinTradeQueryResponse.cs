using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AnttechBlockchainDefinTradeQueryResponse.
    /// </summary>
    public class AnttechBlockchainDefinTradeQueryResponse : AlipayResponse
    {
        /// <summary>
        /// biz_result
        /// </summary>
        [JsonPropertyName("biz_result")]
        public BizResult BizResult { get; set; }
    }
}
