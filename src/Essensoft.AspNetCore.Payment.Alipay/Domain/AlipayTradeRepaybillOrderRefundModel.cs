using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayTradeRepaybillOrderRefundModel Data Structure.
    /// </summary>
    public class AlipayTradeRepaybillOrderRefundModel : AlipayObject
    {
        /// <summary>
        /// 退款金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 支付宝还款账单编号
        /// </summary>
        [JsonPropertyName("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 退款的扩展信息，格式为json字符串
        /// </summary>
        [JsonPropertyName("extend_params")]
        public string ExtendParams { get; set; }

        /// <summary>
        /// 退款备注
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 因为同一笔支付宝还款账单可以多次还款，对应多个还款订单。该字段对应本次需要退款的那笔还款单外部订单号
        /// </summary>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 本次退款请求的外部请求号，用于支付宝内部做幂等控制。同一笔bill_no下out_request_no不能相同，如果相同则代表是重复请求
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }
    }
}
