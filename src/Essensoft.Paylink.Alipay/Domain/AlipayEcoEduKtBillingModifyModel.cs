using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoEduKtBillingModifyModel Data Structure.
    /// </summary>
    public class AlipayEcoEduKtBillingModifyModel : AlipayObject
    {
        /// <summary>
        /// 成功Y，失败N
        /// </summary>
        [JsonPropertyName("bank_success")]
        public string BankSuccess { get; set; }

        /// <summary>
        /// 退款时，支付宝返回的用户的登录id
        /// </summary>
        [JsonPropertyName("buyer_logon_id")]
        public string BuyerLogonId { get; set; }

        /// <summary>
        /// 支付宝返回的买家支付宝用户id
        /// </summary>
        [JsonPropertyName("buyer_user_id")]
        public string BuyerUserId { get; set; }

        /// <summary>
        /// 本次退款是否发生了资金变化
        /// </summary>
        [JsonPropertyName("fund_change")]
        public string FundChange { get; set; }

        /// <summary>
        /// 支付宝返回的退款时间，而不是商户退款申请的时间
        /// </summary>
        [JsonPropertyName("gmt_refund")]
        public string GmtRefund { get; set; }

        /// <summary>
        /// 标识一次退款请求，同一笔交易多次退款需要保证唯一，如需部分退款，则此参数必传。（若退款时填写，则同步退款状态时也必须填写）
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// isv系统的订单号
        /// </summary>
        [JsonPropertyName("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 需要退款的金额，该金额不能大于订单金额,单位为元，支持两位小数
        /// </summary>
        [JsonPropertyName("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 支付宝返回的退款资金渠道，json格式字符串
        /// </summary>
        [JsonPropertyName("refund_detail_item_list")]
        public string RefundDetailItemList { get; set; }

        /// <summary>
        /// 退款原因，商家根据客户实际退款原因填写（若退款时填写，则同步退款状态时也必须填写）
        /// </summary>
        [JsonPropertyName("refund_reason")]
        public string RefundReason { get; set; }

        /// <summary>
        /// 状态：1:缴费成功，2:关闭账单，3、退费  如果为退款状态，需要填写fund_change,   refund_amount, refund_reason,  out_request_no, buyer_logon_id,  gmt_refund,  buyer_user_id, refund_detail_item_list;  4、同步网商返回的状态,如果是网商银行的账单，bank_success这个字段必填
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 支付宝返回的交易号
        /// </summary>
        [JsonPropertyName("trade_no")]
        public string TradeNo { get; set; }
    }
}
