using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayOverseasOpenPreorderCreateModel Data Structure.
    /// </summary>
    public class AlipayOverseasOpenPreorderCreateModel : AlipayObject
    {
        /// <summary>
        /// ISV机构信息
        /// </summary>
        [JsonPropertyName("agent_info")]
        public TuitionISVAgentInfoDTO AgentInfo { get; set; }

        /// <summary>
        /// 是否完成自审
        /// </summary>
        [JsonPropertyName("finish_self_audit")]
        public bool FinishSelfAudit { get; set; }

        /// <summary>
        /// 付款人信息
        /// </summary>
        [JsonPropertyName("payer_info")]
        public TuitionISVPayerInfoDTO PayerInfo { get; set; }

        /// <summary>
        /// 付款信息
        /// </summary>
        [JsonPropertyName("payment_info")]
        public TuitionISVRequestPaymentInfoDTO PaymentInfo { get; set; }

        /// <summary>
        /// 单号
        /// </summary>
        [JsonPropertyName("pre_order_id")]
        public string PreOrderId { get; set; }

        /// <summary>
        /// 学生信息
        /// </summary>
        [JsonPropertyName("student_info")]
        public TuitionISVStudentInfoDTO StudentInfo { get; set; }
    }
}
