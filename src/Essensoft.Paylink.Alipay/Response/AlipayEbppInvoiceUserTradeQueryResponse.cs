using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
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
