using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ApInvoiceBillAmtOpenApiResponse Data Structure.
    /// </summary>
    public class ApInvoiceBillAmtOpenApiResponse : AlipayObject
    {
        /// <summary>
        /// 发票关联账单金额
        /// </summary>
        [JsonPropertyName("ap_bill_amt_list")]
        public List<ApBillAmtOpenApiResponse> ApBillAmtList { get; set; }

        /// <summary>
        /// 发票id
        /// </summary>
        [JsonPropertyName("invoice_id")]
        public string InvoiceId { get; set; }
    }
}
