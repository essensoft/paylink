using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceTransportAdStocktaskresultQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportAdStocktaskresultQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 库存查询结果
        /// </summary>
        [JsonPropertyName("stock_task_result")]
        public StockTaskResult StockTaskResult { get; set; }
    }
}
