using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringOrderPayCancelResponse.
    /// </summary>
    public class KoubeiCateringOrderPayCancelResponse : AlipayResponse
    {
        /// <summary>
        /// 撤销操作:REFUND-退款,CLOSE-关闭
        /// </summary>
        [JsonPropertyName("action")]
        public string Action { get; set; }

        /// <summary>
        /// 外部支付订单号,唯一标识本 次支付的requestID
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
