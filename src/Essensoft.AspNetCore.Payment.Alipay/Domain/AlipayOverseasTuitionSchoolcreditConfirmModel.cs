using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOverseasTuitionSchoolcreditConfirmModel Data Structure.
    /// </summary>
    public class AlipayOverseasTuitionSchoolcreditConfirmModel : AlipayObject
    {
        /// <summary>
        /// 支付内部交易流水号
        /// </summary>
        [JsonPropertyName("alipay_payment_id")]
        public string AlipayPaymentId { get; set; }

        /// <summary>
        /// 汇款入账金额
        /// </summary>
        [JsonPropertyName("confirm_amount")]
        public Money ConfirmAmount { get; set; }

        /// <summary>
        /// 汇款入账结果
        /// </summary>
        [JsonPropertyName("confirm_result")]
        public TuitionISVResult ConfirmResult { get; set; }

        /// <summary>
        /// 汇款入账时间
        /// </summary>
        [JsonPropertyName("confirm_time")]
        public string ConfirmTime { get; set; }

        /// <summary>
        /// ISV内部账单号
        /// </summary>
        [JsonPropertyName("isv_payment_id")]
        public string IsvPaymentId { get; set; }

        /// <summary>
        /// ISV在开放平台入驻签约的PID
        /// </summary>
        [JsonPropertyName("isv_pid")]
        public string IsvPid { get; set; }

        /// <summary>
        /// 业务透传保留字段，json map格式
        /// </summary>
        [JsonPropertyName("pass_through_info")]
        public string PassThroughInfo { get; set; }

        /// <summary>
        /// 学校在开放平台入驻签约的PID
        /// </summary>
        [JsonPropertyName("school_pid")]
        public string SchoolPid { get; set; }
    }
}
