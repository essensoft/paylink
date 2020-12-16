using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceTransportEtcEcodataSyncResponse.
    /// </summary>
    public class AlipayCommerceTransportEtcEcodataSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 同步结果，true/false
        /// </summary>
        [JsonPropertyName("sync_result")]
        public bool SyncResult { get; set; }
    }
}
