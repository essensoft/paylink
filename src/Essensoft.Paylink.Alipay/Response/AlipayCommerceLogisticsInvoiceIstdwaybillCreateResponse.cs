using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
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
        /// 整体的运单开票状态，0：处理中 1：开票成功 2：开票失败
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
