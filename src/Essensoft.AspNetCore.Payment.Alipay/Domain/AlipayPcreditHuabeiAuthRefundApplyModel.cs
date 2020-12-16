using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiAuthRefundApplyModel Data Structure.
    /// </summary>
    public class AlipayPcreditHuabeiAuthRefundApplyModel : AlipayObject
    {
        /// <summary>
        /// 签约花芝的业务协议号，在签约成功、结算成功等通知中回回传给商户。
        /// </summary>
        [JsonPropertyName("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [JsonPropertyName("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 支付宝侧授权操作单据id,在结算扣款成功的通知消息中会回传。在周期扣款场景下，和trade_no必传其中一个值。
        /// </summary>
        [JsonPropertyName("auth_opt_id")]
        public string AuthOptId { get; set; }

        /// <summary>
        /// 本次退款说明
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 外部请求号
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [JsonPropertyName("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 退款金额，单位为：元（人民币），精确到小数点后两位
        /// </summary>
        [JsonPropertyName("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// MEMBER_FEE_REFUND 会员费结算退款 WITHHOLD_FEE_REFUND 周期扣款金额退款 默认为MEMBER_FEE_REFUND
        /// </summary>
        [JsonPropertyName("refund_type")]
        public string RefundType { get; set; }

        /// <summary>
        /// 支付宝交易号,在结算扣款成功的通知中会回传。 在周期扣款场景下，和auth_opt_id必传其中一个值。
        /// </summary>
        [JsonPropertyName("trade_no")]
        public string TradeNo { get; set; }
    }
}
