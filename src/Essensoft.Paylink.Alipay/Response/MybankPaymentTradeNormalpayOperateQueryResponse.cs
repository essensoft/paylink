using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// MybankPaymentTradeNormalpayOperateQueryResponse.
    /// </summary>
    public class MybankPaymentTradeNormalpayOperateQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 预期交易金额，交易请求时的金额，单位:分
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

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
        /// 网商支付、退款、打款等交易的流水号
        /// </summary>
        [JsonPropertyName("operate_no")]
        public string OperateNo { get; set; }

        /// <summary>
        /// 操作状态，ACCEPT：已受理，PROCESSING：处理中，SUCCESS：处理成功，FAIL：处理失败
        /// </summary>
        [JsonPropertyName("operate_state")]
        public string OperateState { get; set; }

        /// <summary>
        /// 操作类型，PAYMENT=支付，REFUND=退款，REMITANCE=打款
        /// </summary>
        [JsonPropertyName("operate_type")]
        public string OperateType { get; set; }

        /// <summary>
        /// 网商订单号
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 真实交易金额，交易达到成功或者失败时，该字段有值，单位:分
        /// </summary>
        [JsonPropertyName("real_amount")]
        public string RealAmount { get; set; }

        /// <summary>
        /// 请求受理时间，格式是yyyyMMddHHmmss
        /// </summary>
        [JsonPropertyName("request_accept_time")]
        public string RequestAcceptTime { get; set; }

        /// <summary>
        /// 请求流水号，外部平台在请求支付、退款、打款等操作时传入的流水号
        /// </summary>
        [JsonPropertyName("request_no")]
        public string RequestNo { get; set; }

        /// <summary>
        /// 交易达到成功、失败的时间，格式是yyyyMMddHHmmss
        /// </summary>
        [JsonPropertyName("trans_time")]
        public string TransTime { get; set; }
    }
}
