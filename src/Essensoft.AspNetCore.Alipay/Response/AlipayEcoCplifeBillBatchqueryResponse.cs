using Newtonsoft.Json;
using System.Collections.Generic;
using Essensoft.AspNetCore.Alipay.Domain;

namespace Essensoft.AspNetCore.Alipay.Response
{
    /// <summary>
    /// AlipayEcoCplifeBillBatchqueryResponse.
    /// </summary>
    public class AlipayEcoCplifeBillBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 若查询到符合条件的账单条目，返回结果集
        /// </summary>
        [JsonProperty("bill_result_set")]
        public List<CPBillResultSet> BillResultSet { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [JsonProperty("current_page_num")]
        public long CurrentPageNum { get; set; }

        /// <summary>
        /// 符合条件的总结果数
        /// </summary>
        [JsonProperty("total_bill_count")]
        public long TotalBillCount { get; set; }
    }
}
