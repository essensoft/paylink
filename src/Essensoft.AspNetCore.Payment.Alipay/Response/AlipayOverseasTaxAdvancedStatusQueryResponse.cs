using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOverseasTaxAdvancedStatusQueryResponse.
    /// </summary>
    public class AlipayOverseasTaxAdvancedStatusQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 用付款码下单并冻结成功后会返回支付宝用户id
        /// </summary>
        [JsonPropertyName("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 退税机构业务流水号
        /// </summary>
        [JsonPropertyName("out_tax_refund_no")]
        public string OutTaxRefundNo { get; set; }

        /// <summary>
        /// 当前订单状态，新建（INIT），预授权退税处理中（ADVANCED_PROCESSING），预授权退税成功（ADVANCED_SUCCESS），预授权退税失败（ADVANCED_FAIL），解冻成功退税完成（FINISH），转交易成功（TRADE_PAY_SUCCESS），转交易失败（TRADE_PAY_FAIL），退款成功（TRADE_REFUND_SUCCESS），退款失败（TRADE_REFUND_FAIL） 各状态下机构对应处理：ADVANCED_PROCESSING继续轮询，ADVANCED_FAIL更换out_tax_refund_no重新调用下单接口，TRADE_PAY_FAIL更新out_request_no重新调用转支付接口，TRADE_REFUND_FAIL已经无法退款，请联系技术支持
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 状态变更时间，时间格式：YYYY-MM-DD HH:MM:SS，北京时间24小时制，时区东八区
        /// </summary>
        [JsonPropertyName("status_change_time")]
        public string StatusChangeTime { get; set; }

        /// <summary>
        /// 状态描述信息，冻结处理中（FREEZE_PROCESSING），冻结失败（FREEZE_FAIL），退税放款处理中（PAYMENT_PROCESSING），退税放款失败解冻中（PAYMENT_FAIL_AND_UNFREEZE_PROCESSING），退税放款失败解冻完成（PAYMENT_FAIL_AND_UNFREEZE_DONE）
        /// </summary>
        [JsonPropertyName("status_msg")]
        public string StatusMsg { get; set; }

        /// <summary>
        /// 支付宝退税资金订单号
        /// </summary>
        [JsonPropertyName("tax_refund_no")]
        public string TaxRefundNo { get; set; }
    }
}
