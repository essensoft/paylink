using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AnttechBlockchainFinanceAssetRegisterSubmitResponse.
    /// </summary>
    public class AnttechBlockchainFinanceAssetRegisterSubmitResponse : AlipayResponse
    {
        /// <summary>
        /// 提交结果，根据operate不同而不同。
        /// </summary>
        [JsonPropertyName("submit_result")]
        public string SubmitResult { get; set; }
    }
}
