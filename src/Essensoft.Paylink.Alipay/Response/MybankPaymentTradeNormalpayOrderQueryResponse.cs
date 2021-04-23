using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// MybankPaymentTradeNormalpayOrderQueryResponse.
    /// </summary>
    public class MybankPaymentTradeNormalpayOrderQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 订单金额，单位:分
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 渠道类型，表示请求的来源，ANT_OPEN=蚂蚁开放平台
        /// </summary>
        [JsonPropertyName("biz_channel")]
        public string BizChannel { get; set; }

        /// <summary>
        /// 外部平台的单据号
        /// </summary>
        [JsonPropertyName("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 币种，156=人民币
        /// </summary>
        [JsonPropertyName("currency_value")]
        public string CurrencyValue { get; set; }

        /// <summary>
        /// 扩展参数，内容是JSON格式，并用urlconde编码
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 网商订单号
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 订单状态，PAYED=支付成功，CLOSED=关闭，INIT=待支付，FINISH=完结(不允许发起任何交易)，FAIL=支付失败
        /// </summary>
        [JsonPropertyName("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 订单类型，NORMAL_PAY=通用支付
        /// </summary>
        [JsonPropertyName("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 已支付金额，单位:分
        /// </summary>
        [JsonPropertyName("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 支付时间，格式是yyyyMMddHHmmss
        /// </summary>
        [JsonPropertyName("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 在途支付金额，表示已受理但未达到终态的金额，这部分金额，成功时转化为已支付金额，失败时归零，单位:分
        /// </summary>
        [JsonPropertyName("paying_amount")]
        public string PayingAmount { get; set; }

        /// <summary>
        /// 已打款金额，单位:分
        /// </summary>
        [JsonPropertyName("receipt_amount")]
        public string ReceiptAmount { get; set; }

        /// <summary>
        /// 在途打款金额，表示已受理但未达到终态的金额，这部分金额，成功时转化为已打款金额，失败时归零，单位:分
        /// </summary>
        [JsonPropertyName("receipting_amount")]
        public string ReceiptingAmount { get; set; }

        /// <summary>
        /// 已退款金额，单位:分
        /// </summary>
        [JsonPropertyName("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 请求受理时间，格式是yyyyMMddHHmmss
        /// </summary>
        [JsonPropertyName("request_accept_time")]
        public string RequestAcceptTime { get; set; }

        /// <summary>
        /// 请求流水号
        /// </summary>
        [JsonPropertyName("request_no")]
        public string RequestNo { get; set; }
    }
}
