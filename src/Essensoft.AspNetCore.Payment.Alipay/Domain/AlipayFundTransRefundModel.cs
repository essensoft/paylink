using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayFundTransRefundModel Data Structure.
    /// </summary>
    public class AlipayFundTransRefundModel : AlipayObject
    {
        /// <summary>
        /// JSON格式，传递业务扩展参数，使用前请与支付宝工程师联系！
        /// </summary>
        [JsonPropertyName("business_params")]
        public string BusinessParams { get; set; }

        /// <summary>
        /// 发红包时支付宝返回的支付宝订单号order_id。
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 标识一次资金退回请求，一笔资金退回失败后重新提交，要采用原来的资金退回单号。总退款金额不能超过用户实际支付金额。
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 公用回传参数，如果请求时传递了该参数，则异步通知商户时会回传该参数。
        /// </summary>
        [JsonPropertyName("passback_params")]
        public string PassbackParams { get; set; }

        /// <summary>
        /// 需要退款的金额，该金额不能大于订单金额,单位为元，支持两位小数
        /// </summary>
        [JsonPropertyName("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 资金退回备注
        /// </summary>
        [JsonPropertyName("remark")]
        public string Remark { get; set; }
    }
}
