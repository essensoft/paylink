using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcoMycarParkingOrderPayResponse.
    /// </summary>
    public class AlipayEcoMycarParkingOrderPayResponse : AlipayResponse
    {
        /// <summary>
        /// 垫资金额，不返回表示没有走垫资非空表示垫资支付的金额
        /// </summary>
        [JsonPropertyName("advance_amount")]
        public string AdvanceAmount { get; set; }

        /// <summary>
        /// 如果垫资金额不为空，则返回支付宝停车平台用户主动还款链接。服务商引导用户点击链接时，会跳转到用户在支付宝停车平台的待还款页面。  服务商可保存该链接作为用户还款入口地址。
        /// </summary>
        [JsonPropertyName("alipay_repayment_url")]
        public string AlipayRepaymentUrl { get; set; }

        /// <summary>
        /// 本次交易使用的支付渠道信息。详见（支付渠道信息）
        /// </summary>
        [JsonPropertyName("fund_bill_list")]
        public string FundBillList { get; set; }

        /// <summary>
        /// 该笔交易的买家付款时间。  格式为yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("gmt_payment")]
        public string GmtPayment { get; set; }

        /// <summary>
        /// 对应商户网站的订单系统中的唯一订单号，非支付宝交易号。  需保证在商户网站中的唯一性。是请求时对应的参数，原样返回。
        /// </summary>
        [JsonPropertyName("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 交易金额  保留小数点后两位
        /// </summary>
        [JsonPropertyName("total_fee")]
        public string TotalFee { get; set; }

        /// <summary>
        /// 该交易在支付宝系统中的交易流水号。系统唯一，最短16位，最长64位
        /// </summary>
        [JsonPropertyName("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 买家支付宝用户ID，用于标识订单扣款用户及订单回传使用
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
