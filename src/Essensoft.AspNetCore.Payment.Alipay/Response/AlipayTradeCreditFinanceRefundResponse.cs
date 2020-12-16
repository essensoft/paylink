using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayTradeCreditFinanceRefundResponse.
    /// </summary>
    public class AlipayTradeCreditFinanceRefundResponse : AlipayResponse
    {
        /// <summary>
        /// 本次退款的金额，非特殊情况下和请求金额保持一致。单位为元；精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 本次金融退款的支付宝单号
        /// </summary>
        [JsonPropertyName("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 币种单位，目前只支持人民币CNY
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 支付宝系统资金处理成功时间，格式为"yyyy-MM-dd HH:mm:ss"
        /// </summary>
        [JsonPropertyName("gmt_refund_pay")]
        public string GmtRefundPay { get; set; }

        /// <summary>
        /// 外部请求号，和请求入参一致
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 本次退款的处理状态，SUCCESS：处理成功；FAIL：处理失败
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 本次金融退款对应的交易号
        /// </summary>
        [JsonPropertyName("trade_no")]
        public string TradeNo { get; set; }
    }
}
