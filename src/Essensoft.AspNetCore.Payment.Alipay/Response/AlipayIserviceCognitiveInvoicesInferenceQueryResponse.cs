using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayIserviceCognitiveInvoicesInferenceQueryResponse.
    /// </summary>
    public class AlipayIserviceCognitiveInvoicesInferenceQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 算法版本
        /// </summary>
        [JsonPropertyName("algo_version")]
        public string AlgoVersion { get; set; }

        /// <summary>
        /// 增值税发票内容
        /// </summary>
        [JsonPropertyName("content")]
        public TaxBillContent Content { get; set; }

        /// <summary>
        /// 当ret不为0，err_msg记录详细错误原因
        /// </summary>
        [JsonPropertyName("err_msg")]
        public string ErrMsg { get; set; }

        /// <summary>
        /// 返回值
        /// </summary>
        [JsonPropertyName("ret")]
        public string Ret { get; set; }
    }
}
