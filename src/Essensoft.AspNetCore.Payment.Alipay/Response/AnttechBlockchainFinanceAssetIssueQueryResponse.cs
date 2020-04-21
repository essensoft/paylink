using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AnttechBlockchainFinanceAssetIssueQueryResponse.
    /// </summary>
    public class AnttechBlockchainFinanceAssetIssueQueryResponse : AlipayResponse
    {
        /// <summary>
        /// status=FAILED时，描述发行失败原因的错误码
        /// </summary>
        [JsonPropertyName("failed_code")]
        public string FailedCode { get; set; }

        /// <summary>
        /// status=FAILED时，描述发行失败原因的详细解释
        /// </summary>
        [JsonPropertyName("failed_desc")]
        public string FailedDesc { get; set; }

        /// <summary>
        /// 当资产类型为RECEIVABLE时必选，应收账款发行结果信息
        /// </summary>
        [JsonPropertyName("receivable_result_info")]
        public FinanceReceivableResultInfo ReceivableResultInfo { get; set; }

        /// <summary>
        /// resultInfo为SUCCESS时必选。资产发行状态，PROCESSING:进行中，SUCCESS:成功，FAILED:失败
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
