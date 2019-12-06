using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcoCplifeBillBatchqueryResponse.
    /// </summary>
    public class AlipayEcoCplifeBillBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 若查询到符合条件的账单条目，返回结果集
        /// </summary>
        [JsonPropertyName("bill_result_set")]
        public List<CPBillResultSet> BillResultSet { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [JsonPropertyName("current_page_num")]
        public long CurrentPageNum { get; set; }

        /// <summary>
        /// 符合条件的总结果数
        /// </summary>
        [JsonPropertyName("total_bill_count")]
        public long TotalBillCount { get; set; }
    }
}
