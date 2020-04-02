using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayBusinessPaymenthubPayResponse.
    /// </summary>
    public class AlipayBusinessPaymenthubPayResponse : AlipayResponse
    {
        /// <summary>
        /// 聚合支付的支付渠道，支付宝分配。
        /// </summary>
        [JsonPropertyName("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 支付金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [JsonPropertyName("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 支付请求号，对应一笔业务订单下的一次支付请求，不同支付请求需保证请求号唯一
        /// </summary>
        [JsonPropertyName("pay_request_no")]
        public string PayRequestNo { get; set; }

        /// <summary>
        /// 支付状态，目前支持如下值： WAIT（支付已受理），异步支付场景，受理成功后为该状态，业务上需等待后续的异步成功通知； SUCCESS（支付成功），该状态表示该笔支付已成功处理； FAIL（支付失败），该状态表示该笔支付已失败，并且不可重试，后续如果要重新支付，需要更换支付请求号。
        /// </summary>
        [JsonPropertyName("pay_status")]
        public string PayStatus { get; set; }

        /// <summary>
        /// 支付id，支付宝针对每一笔支付请求生成的唯一支付凭证，后续打款和退款时候需带入此id
        /// </summary>
        [JsonPropertyName("payment_id")]
        public string PaymentId { get; set; }
    }
}
