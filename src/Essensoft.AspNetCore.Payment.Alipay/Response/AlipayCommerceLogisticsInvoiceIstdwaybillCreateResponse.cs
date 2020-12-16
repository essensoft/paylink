using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceLogisticsInvoiceIstdwaybillCreateResponse.
    /// </summary>
    public class AlipayCommerceLogisticsInvoiceIstdwaybillCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 开票金额
        /// </summary>
        [JsonPropertyName("invoice_fee")]
        public string InvoiceFee { get; set; }

        /// <summary>
        /// 开票的整体结果，0：处理中 1：已开票  2：开票失败
        /// </summary>
        [JsonPropertyName("status")]
        public long Status { get; set; }

        /// <summary>
        /// 即时配送运单列表
        /// </summary>
        [JsonPropertyName("waybill_invoices")]
        public List<WaybillInvoiceIstd> WaybillInvoices { get; set; }
    }
}
