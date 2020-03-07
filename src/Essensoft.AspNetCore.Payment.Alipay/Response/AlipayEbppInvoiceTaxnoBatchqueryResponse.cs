using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEbppInvoiceTaxnoBatchqueryResponse.
    /// </summary>
    public class AlipayEbppInvoiceTaxnoBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 发票要素列表
        /// </summary>
        [JsonPropertyName("invoice_element_list")]
        public List<InvoiceElementModel> InvoiceElementList { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
