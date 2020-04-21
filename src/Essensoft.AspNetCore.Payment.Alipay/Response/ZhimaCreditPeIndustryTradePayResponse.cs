using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZhimaCreditPeIndustryTradePayResponse.
    /// </summary>
    public class ZhimaCreditPeIndustryTradePayResponse : AlipayResponse
    {
        /// <summary>
        /// 交易资金流水号
        /// </summary>
        [JsonPropertyName("alipay_fund_order_no")]
        public string AlipayFundOrderNo { get; set; }

        /// <summary>
        /// 交易外部订单号,交易成功才有值,商户对账使用
        /// </summary>
        [JsonPropertyName("alipay_out_trade_no")]
        public string AlipayOutTradeNo { get; set; }

        /// <summary>
        /// 支付金额,单位元
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 支付失败原因描述
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; }

        /// <summary>
        /// 传入的扣款资金单号
        /// </summary>
        [JsonPropertyName("out_fund_no")]
        public string OutFundNo { get; set; }

        /// <summary>
        /// 传入的资金类型
        /// </summary>
        [JsonPropertyName("pay_amount_type")]
        public string PayAmountType { get; set; }

        /// <summary>
        /// 支付状态,支付成功:PAY_SUCCESS, 支付失败:PAY_FAILED, 支付中:PAY_INPROGRESS
        /// </summary>
        [JsonPropertyName("pay_status")]
        public string PayStatus { get; set; }

        /// <summary>
        /// 支付处理时间，无支付行为时为空
        /// </summary>
        [JsonPropertyName("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 平台订单号
        /// </summary>
        [JsonPropertyName("zm_order_id")]
        public string ZmOrderId { get; set; }
    }
}
