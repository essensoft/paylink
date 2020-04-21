using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEbppInvoiceUserTradeQueryResponse.
    /// </summary>
    public class AlipayEbppInvoiceUserTradeQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 发票管家发票交易信息
        /// </summary>
        [JsonPropertyName("trade_info")]
        public InvoiceTradeInfo TradeInfo { get; set; }
    }
}
