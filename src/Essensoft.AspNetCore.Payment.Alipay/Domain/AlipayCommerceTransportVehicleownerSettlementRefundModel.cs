using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceTransportVehicleownerSettlementRefundModel Data Structure.
    /// </summary>
    public class AlipayCommerceTransportVehicleownerSettlementRefundModel : AlipayObject
    {
        /// <summary>
        /// 业务协议号，通过外部单号发起时这个参数必传； 以下两个传参方法二选一： 1、协议号+外部订单号 2、交易号
        /// </summary>
        [JsonPropertyName("biz_agreement_no")]
        public string BizAgreementNo { get; set; }

        /// <summary>
        /// 标识一次退款请求，同一笔交易多次退款需要保证唯一，如需部分退款，则此参数必传。
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 订单支付时传入的商户订单号，支付宝交易号和（商户订单号+协议号）不能同时为空
        /// </summary>
        [JsonPropertyName("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 需要退款的金额，该金额不能大于订单金额,单位为元，支持两位小数
        /// </summary>
        [JsonPropertyName("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 支付宝交易号,支付宝交易号和（商户订单号+协议号）不能同时为空
        /// </summary>
        [JsonPropertyName("trade_no")]
        public string TradeNo { get; set; }
    }
}
