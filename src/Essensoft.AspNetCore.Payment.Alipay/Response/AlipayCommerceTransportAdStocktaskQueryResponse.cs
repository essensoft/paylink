using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceTransportAdStocktaskQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportAdStocktaskQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 库存任务执行情况
        /// </summary>
        [JsonPropertyName("stock_task")]
        public StockTask StockTask { get; set; }
    }
}
