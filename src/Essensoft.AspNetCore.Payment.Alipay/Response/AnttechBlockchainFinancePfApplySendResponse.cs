using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AnttechBlockchainFinancePfApplySendResponse.
    /// </summary>
    public class AnttechBlockchainFinancePfApplySendResponse : AlipayResponse
    {
        /// <summary>
        /// 支用标识
        /// </summary>
        [JsonPropertyName("financing_id")]
        public string FinancingId { get; set; }

        /// <summary>
        /// passed
        /// </summary>
        [JsonPropertyName("msg")]
        public new string Msg { get; set; }

        /// <summary>
        /// 平台标识
        /// </summary>
        [JsonPropertyName("platform_id")]
        public string PlatformId { get; set; }
    }
}
