using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AnttechBlockchainFinancePfPaymentQueryResponse.
    /// </summary>
    public class AnttechBlockchainFinancePfPaymentQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 入账状态
        /// </summary>
        [JsonPropertyName("account_in_status")]
        public string AccountInStatus { get; set; }

        /// <summary>
        /// 个性化参数
        /// </summary>
        [JsonPropertyName("parm")]
        public string Parm { get; set; }
    }
}
