using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiSalesKbassetStuffProduceorderBatchqueryResponse.
    /// </summary>
    public class KoubeiSalesKbassetStuffProduceorderBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 当前是否还有生产指令可以拉取; 注意如果该值为false, 也只是提示当前没有更多生产指令了, 不代表后面没有生产指令, 商户需要自己制定策略定时去拉取.
        /// </summary>
        [JsonPropertyName("has_next_page")]
        public bool HasNextPage { get; set; }

        /// <summary>
        /// 生产单结果列表
        /// </summary>
        [JsonPropertyName("list")]
        public List<AccessProduceOrder> List { get; set; }
    }
}
