using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringOrderPayApplyResponse.
    /// </summary>
    public class KoubeiCateringOrderPayApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 外部支付订单号,唯一标识本次支付的requestID
        /// </summary>
        [JsonPropertyName("out_pay_no")]
        public string OutPayNo { get; set; }

        /// <summary>
        /// 口碑内部支付订单号,和外部支付订单号一一映射
        /// </summary>
        [JsonPropertyName("pay_no")]
        public string PayNo { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [JsonPropertyName("trade_no")]
        public string TradeNo { get; set; }
    }
}
