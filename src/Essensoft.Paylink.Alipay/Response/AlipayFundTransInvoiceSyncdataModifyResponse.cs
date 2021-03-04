using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayFundTransInvoiceSyncdataModifyResponse.
    /// </summary>
    public class AlipayFundTransInvoiceSyncdataModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 票据详情页url
        /// </summary>
        [JsonPropertyName("invoice_url")]
        public string InvoiceUrl { get; set; }
    }
}
