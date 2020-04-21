using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiRetailWmsOutboundorderCreateResponse.
    /// </summary>
    public class KoubeiRetailWmsOutboundorderCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 出库通知单号
        /// </summary>
        [JsonPropertyName("outbound_order_id")]
        public string OutboundOrderId { get; set; }
    }
}
