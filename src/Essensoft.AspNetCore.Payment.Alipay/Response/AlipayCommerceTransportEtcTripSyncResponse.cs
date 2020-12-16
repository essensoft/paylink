using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceTransportEtcTripSyncResponse.
    /// </summary>
    public class AlipayCommerceTransportEtcTripSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 是否同步成功，true/false
        /// </summary>
        [JsonPropertyName("sync_result")]
        public bool SyncResult { get; set; }
    }
}
