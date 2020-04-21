using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiRetailWmsInboundworkCreateResponse.
    /// </summary>
    public class KoubeiRetailWmsInboundworkCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 入库作业id
        /// </summary>
        [JsonPropertyName("inbound_work_id")]
        public string InboundWorkId { get; set; }
    }
}
