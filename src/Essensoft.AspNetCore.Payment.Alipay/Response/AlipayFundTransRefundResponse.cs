using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayFundTransRefundResponse.
    /// </summary>
    public class AlipayFundTransRefundResponse : AlipayResponse
    {
        /// <summary>
        /// 发红包时支付宝返回的支付宝订单号order_id。
        /// </summary>
        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 标识一次资金退回请求，一笔资金退回失败后重新提交，要采用原来的资金退回单号。总退款金额不能超过用户实际支付金额。
        /// </summary>
        [JsonProperty("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 本次退款的金额，单位为元，支持两位小数
        /// </summary>
        [JsonProperty("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 退款资金退回
        /// </summary>
        [JsonProperty("refund_date")]
        public string RefundDate { get; set; }

        /// <summary>
        /// 退款的支付宝系统内部单据id
        /// </summary>
        [JsonProperty("refund_order_id")]
        public string RefundOrderId { get; set; }

        /// <summary>
        /// SUCCESS：退款成功
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
