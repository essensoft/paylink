using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceTransportAdStocktaskBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceTransportAdStocktaskBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 库存查询任务
        /// </summary>
        [JsonPropertyName("stock_task")]
        public List<StockTask> StockTask { get; set; }
    }
}
