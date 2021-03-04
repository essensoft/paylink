using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayEbppInvoiceTokenBatchqueryResponse.
    /// </summary>
    public class AlipayEbppInvoiceTokenBatchqueryResponse : AlipayResponse
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
