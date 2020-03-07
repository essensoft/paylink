using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEbppInvoiceInfoGetResponse.
    /// </summary>
    public class AlipayEbppInvoiceInfoGetResponse : AlipayResponse
    {
        /// <summary>
        /// 电子发票详情模型
        /// </summary>
        [JsonPropertyName("invoice_model")]
        public InvoiceModelContent InvoiceModel { get; set; }
    }
}
