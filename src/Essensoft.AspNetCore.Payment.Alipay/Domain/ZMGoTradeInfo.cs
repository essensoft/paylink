using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZMGoTradeInfo Data Structure.
    /// </summary>
    public class ZMGoTradeInfo : AlipayObject
    {
        /// <summary>
        /// 用户和商户发生交易的交易单金额，单位元
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 用户和商户发生交易的交易单号，仅在商户需要回传交易信息时传入。
        /// </summary>
        [JsonPropertyName("trade_no")]
        public string TradeNo { get; set; }
    }
}
