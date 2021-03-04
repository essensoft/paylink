using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayEbppInvoiceTitleDynamicGetResponse.
    /// </summary>
    public class AlipayEbppInvoiceTitleDynamicGetResponse : AlipayResponse
    {
        /// <summary>
        /// 发票抬头
        /// </summary>
        [JsonPropertyName("title")]
        public InvoiceTitleModel Title { get; set; }
    }
}
