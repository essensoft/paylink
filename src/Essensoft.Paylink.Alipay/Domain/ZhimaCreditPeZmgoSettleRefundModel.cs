using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ZhimaCreditPeZmgoSettleRefundModel Data Structure.
    /// </summary>
    public class ZhimaCreditPeZmgoSettleRefundModel : AlipayObject
    {
        /// <summary>
        /// 签约芝麻GO的业务协议号，在签约成功、结算成功等通知中回回传给商户。
        /// </summary>
        [JsonPropertyName("agreement_id")]
        public string AgreementId { get; set; }

        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [JsonPropertyName("alipay_user_id")]
        public string AlipayUserId { get; set; }

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
        /// 退款类型： MEMBER_FEE_REFUND 会员费结算退款 ，WITHHOLD_FEE_REFUND 周期扣款金额退款。 不填写默认为 MEMBER_FEE_REFUND
        /// </summary>
        [JsonPropertyName("refund_type")]
        public string RefundType { get; set; }

        /// <summary>
        /// 芝麻侧扣款计划单据号，在结算扣款成功的通知消息中会回传。
        /// </summary>
        [JsonPropertyName("withhold_plan_no")]
        public string WithholdPlanNo { get; set; }
    }
}
