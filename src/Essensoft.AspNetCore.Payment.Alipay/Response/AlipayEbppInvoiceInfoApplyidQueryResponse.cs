using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEbppInvoiceInfoApplyidQueryResponse.
    /// </summary>
    public class AlipayEbppInvoiceInfoApplyidQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 发票信息
        /// </summary>
        [JsonPropertyName("invoice_info")]
        public List<InvoiceQueryOpenModel> InvoiceInfo { get; set; }
    }
}
