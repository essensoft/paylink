using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayEbppInvoiceTopregisterRegisterCreateResponse.
    /// </summary>
    public class AlipayEbppInvoiceTopregisterRegisterCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 工单ID
        /// </summary>
        [JsonPropertyName("register_id")]
        public string RegisterId { get; set; }
    }
}
