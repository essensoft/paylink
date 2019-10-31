using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayDataBillSellQueryResponse.
    /// </summary>
    public class AlipayDataBillSellQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 交易流水详情
        /// </summary>
        [JsonProperty("detail_list")]
        public List<TradeItemResult> DetailList { get; set; }

        /// <summary>
        /// 分页号，从1开始
        /// </summary>
        [JsonProperty("page_no")]
        public string PageNo { get; set; }

        /// <summary>
        /// 分页大小1000-2000
        /// </summary>
        [JsonProperty("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 账务明细总数。返回满足查询条件的明细的数量
        /// </summary>
        [JsonProperty("total_size")]
        public string TotalSize { get; set; }
    }
}
