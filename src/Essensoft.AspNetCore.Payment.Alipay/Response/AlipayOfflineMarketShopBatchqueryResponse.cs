using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOfflineMarketShopBatchqueryResponse.
    /// </summary>
    public class AlipayOfflineMarketShopBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 当前页码
        /// </summary>
        [JsonPropertyName("current_pageno")]
        public string CurrentPageno { get; set; }

        /// <summary>
        /// 门店列表ID，逗号分隔
        /// </summary>
        [JsonPropertyName("shop_ids")]
        public List<string> ShopIds { get; set; }

        /// <summary>
        /// 总页码数目
        /// </summary>
        [JsonPropertyName("total_pageno")]
        public string TotalPageno { get; set; }
    }
}
