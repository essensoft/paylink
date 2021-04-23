using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceLogisticsInvoiceIstdwaybillQueryResponse.
    /// </summary>
    public class AlipayCommerceLogisticsInvoiceIstdwaybillQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 整体的运单开票状态，0：处理中 1：开票成功 2：开票失败
        /// </summary>
        [JsonPropertyName("status")]
        public long Status { get; set; }

        /// <summary>
        /// 即时配送运单列表
        /// </summary>
        [JsonPropertyName("waybill_invoices")]
        public List<WaybillInvoiceQueryIstd> WaybillInvoices { get; set; }
    }
}
