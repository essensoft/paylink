using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayFinanceQuotationQuotetradeSymbolsQueryResponse.
    /// </summary>
    public class AlipayFinanceQuotationQuotetradeSymbolsQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 股票的唯一代码：symbol=code.market
        /// </summary>
        [JsonPropertyName("data")]
        public List<string> Data { get; set; }
    }
}
