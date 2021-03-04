using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AmapMapMapserviceTeseBatchqueryResponse.
    /// </summary>
    public class AmapMapMapserviceTeseBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [JsonPropertyName("es")]
        public string Es { get; set; }
    }
}
