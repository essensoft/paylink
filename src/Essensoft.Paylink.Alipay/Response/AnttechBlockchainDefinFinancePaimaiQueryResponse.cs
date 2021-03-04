using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AnttechBlockchainDefinFinancePaimaiQueryResponse.
    /// </summary>
    public class AnttechBlockchainDefinFinancePaimaiQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 业务结果
        /// </summary>
        [JsonPropertyName("biz_result")]
        public BizResult BizResult { get; set; }
    }
}
