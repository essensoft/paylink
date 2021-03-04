using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayIserviceCcmAgentCreateResponse.
    /// </summary>
    public class AlipayIserviceCcmAgentCreateResponse : AlipayResponse
    {
        /// <summary>
        /// CCM客服id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}
