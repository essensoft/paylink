using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEbppInvoiceFinancialBlockchainBatchqueryResponse.
    /// </summary>
    public class AlipayEbppInvoiceFinancialBlockchainBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 发票列表
        /// </summary>
        [JsonPropertyName("invoice_element_list")]
        public List<InvoiceElementModel> InvoiceElementList { get; set; }
    }
}
