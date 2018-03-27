using Newtonsoft.Json;
using System.Collections.Generic;

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
        [JsonProperty("current_pageno")]
        public string CurrentPageno { get; set; }

        /// <summary>
        /// 门店列表ID，逗号分隔
        /// </summary>
        [JsonProperty("shop_ids")]
        public List<string> ShopIds { get; set; }

        /// <summary>
        /// 总页码数目
        /// </summary>
        [JsonProperty("total_pageno")]
        public string TotalPageno { get; set; }
    }
}
