using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayBossFncInvoicreceiptQueryModel Data Structure.
    /// </summary>
    public class AlipayBossFncInvoicreceiptQueryModel : AlipayObject
    {
        /// <summary>
        /// 对账单号
        /// </summary>
        [JsonPropertyName("statement_bill_nos")]
        public List<string> StatementBillNos { get; set; }
    }
}
