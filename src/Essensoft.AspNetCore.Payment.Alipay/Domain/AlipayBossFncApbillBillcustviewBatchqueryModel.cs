using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayBossFncApbillBillcustviewBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayBossFncApbillBillcustviewBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 月账单号列表
        /// </summary>
        [JsonPropertyName("bill_nos")]
        public List<string> BillNos { get; set; }

        /// <summary>
        /// 发票种类{"01":"增值税专用发票","02":"增值税普通发票","05":"其它发票","07":"虚拟发票"}
        /// </summary>
        [JsonPropertyName("invoice_type")]
        public string InvoiceType { get; set; }
    }
}
