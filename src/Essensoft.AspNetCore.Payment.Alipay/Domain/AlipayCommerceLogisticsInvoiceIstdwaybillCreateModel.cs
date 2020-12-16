using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceLogisticsInvoiceIstdwaybillCreateModel Data Structure.
    /// </summary>
    public class AlipayCommerceLogisticsInvoiceIstdwaybillCreateModel : AlipayObject
    {
        /// <summary>
        /// 发票信息
        /// </summary>
        [JsonPropertyName("invoice")]
        public Invoice Invoice { get; set; }

        /// <summary>
        /// 即时配送公司编码
        /// </summary>
        [JsonPropertyName("logistics_code")]
        public string LogisticsCode { get; set; }

        /// <summary>
        /// 开票请求流水号
        /// </summary>
        [JsonPropertyName("out_invoice_request_no")]
        public string OutInvoiceRequestNo { get; set; }

        /// <summary>
        /// 即时配送运单列表
        /// </summary>
        [JsonPropertyName("waybill_invoices")]
        public List<WaybillInvoice> WaybillInvoices { get; set; }
    }
}
