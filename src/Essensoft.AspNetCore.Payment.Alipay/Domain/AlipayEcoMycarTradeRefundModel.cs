using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoMycarTradeRefundModel Data Structure.
    /// </summary>
    public class AlipayEcoMycarTradeRefundModel : AlipayObject
    {
        /// <summary>
        /// 渠道平台
        /// </summary>
        [JsonPropertyName("isv")]
        public string Isv { get; set; }

        /// <summary>
        /// 退款金额(分)
        /// </summary>
        [JsonPropertyName("refund_fee")]
        public string RefundFee { get; set; }

        /// <summary>
        /// 退款原因
        /// </summary>
        [JsonPropertyName("refund_reason")]
        public string RefundReason { get; set; }

        /// <summary>
        /// 退款交易编号
        /// </summary>
        [JsonPropertyName("trade_no")]
        public string TradeNo { get; set; }
    }
}
