using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMallScanpurchaseTradePayResponse.
    /// </summary>
    public class KoubeiMallScanpurchaseTradePayResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝收银单号
        /// </summary>
        [JsonPropertyName("cashier_id")]
        public string CashierId { get; set; }

        /// <summary>
        /// 口碑商圈订单ID
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [JsonPropertyName("trade_no")]
        public string TradeNo { get; set; }
    }
}
