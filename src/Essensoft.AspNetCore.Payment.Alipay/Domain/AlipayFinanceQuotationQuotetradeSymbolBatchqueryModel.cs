using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayFinanceQuotationQuotetradeSymbolBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayFinanceQuotationQuotetradeSymbolBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 股票唯一编码，symbol=code.market
        /// </summary>
        [JsonPropertyName("symbols")]
        public List<string> Symbols { get; set; }
    }
}
