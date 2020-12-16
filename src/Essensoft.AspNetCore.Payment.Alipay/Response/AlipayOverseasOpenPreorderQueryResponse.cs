using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOverseasOpenPreorderQueryResponse.
    /// </summary>
    public class AlipayOverseasOpenPreorderQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 机构信息
        /// </summary>
        [JsonPropertyName("agent_info")]
        public TuitionISVAgentInfoDTO AgentInfo { get; set; }

        /// <summary>
        /// payment_info
        /// </summary>
        [JsonPropertyName("payment_info")]
        public TuitionISVResponsePaymentInfoDTO PaymentInfo { get; set; }

        /// <summary>
        /// 预缴费单据号
        /// </summary>
        [JsonPropertyName("pre_order_id")]
        public string PreOrderId { get; set; }

        /// <summary>
        /// 留学汇款对isv返回结果
        /// </summary>
        [JsonPropertyName("result")]
        public TuitionISVResult Result { get; set; }

        /// <summary>
        /// 单据状态
        /// </summary>
        [JsonPropertyName("status_code")]
        public string StatusCode { get; set; }

        /// <summary>
        /// TuitionISVStudentInfoDTO
        /// </summary>
        [JsonPropertyName("student_info")]
        public TuitionISVStudentInfoDTO StudentInfo { get; set; }
    }
}
