using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
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
