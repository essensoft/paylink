using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
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
