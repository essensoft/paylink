using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
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
