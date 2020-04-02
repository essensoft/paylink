using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOverseasTravelRateCurrencyBatchqueryResponse.
    /// </summary>
    public class AlipayOverseasTravelRateCurrencyBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 汇率币种列表
        /// </summary>
        [JsonPropertyName("currency_list")]
        public List<RateCurrency> CurrencyList { get; set; }
    }
}
