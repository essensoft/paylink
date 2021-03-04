using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingDataEquitySyncResponse.
    /// </summary>
    public class AlipayMarketingDataEquitySyncResponse : AlipayResponse
    {
        /// <summary>
        /// true/false
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
