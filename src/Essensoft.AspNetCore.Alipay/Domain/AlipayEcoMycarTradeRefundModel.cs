using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoMycarTradeRefundModel Data Structure.
    /// </summary>
    public class AlipayEcoMycarTradeRefundModel : AlipayObject
    {
        /// <summary>
        /// 渠道平台
        /// </summary>
        [JsonProperty("isv")]
        public string Isv { get; set; }

        /// <summary>
        /// 退款金额(分)
        /// </summary>
        [JsonProperty("refund_fee")]
        public string RefundFee { get; set; }

        /// <summary>
        /// 退款原因
        /// </summary>
        [JsonProperty("refund_reason")]
        public string RefundReason { get; set; }

        /// <summary>
        /// 退款交易编号
        /// </summary>
        [JsonProperty("trade_no")]
        public string TradeNo { get; set; }
    }
}
