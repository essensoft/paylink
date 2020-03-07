using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiRetailWmsOutboundworkCreateResponse.
    /// </summary>
    public class KoubeiRetailWmsOutboundworkCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 出库作业id
        /// </summary>
        [JsonPropertyName("outbound_work_id")]
        public string OutboundWorkId { get; set; }
    }
}
