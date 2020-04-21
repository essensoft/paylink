using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOfflineMarketProductBatchqueryResponse.
    /// </summary>
    public class AlipayOfflineMarketProductBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 当前页码
        /// </summary>
        [JsonPropertyName("current_pageno")]
        public long CurrentPageno { get; set; }

        /// <summary>
        /// 商品列表ID，逗号分隔
        /// </summary>
        [JsonPropertyName("item_ids")]
        public List<string> ItemIds { get; set; }

        /// <summary>
        /// 总页码数
        /// </summary>
        [JsonPropertyName("total_pageno")]
        public long TotalPageno { get; set; }
    }
}
