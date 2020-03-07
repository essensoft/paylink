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
    }
}
