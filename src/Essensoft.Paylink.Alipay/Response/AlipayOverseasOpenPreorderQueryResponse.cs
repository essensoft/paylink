using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
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
        /// 付款金额
        /// </summary>
        [JsonPropertyName("payment_amount")]
        public TuitionISVAmountInfoDTO PaymentAmount { get; set; }

        /// <summary>
        /// payment_info（已废弃）
        /// </summary>
        [JsonPropertyName("payment_info")]
        public TuitionISVResponsePaymentInfoDTO PaymentInfo { get; set; }

        /// <summary>
        /// 预缴费单据号
        /// </summary>
        [JsonPropertyName("pre_order_id")]
        public string PreOrderId { get; set; }

        /// <summary>
        /// 退款金额
        /// </summary>
        [JsonPropertyName("refund_amount")]
        public TuitionISVAmountInfoDTO RefundAmount { get; set; }

        /// <summary>
        /// 留学汇款对isv返回结果
        /// </summary>
        [JsonPropertyName("result")]
        public TuitionISVResult Result { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [JsonPropertyName("status")]
        public TuitionISVOrderStatusDTO Status { get; set; }

        /// <summary>
        /// 单据状态（已废弃）
        /// </summary>
        [JsonPropertyName("status_code")]
        public string StatusCode { get; set; }

        /// <summary>
        /// TuitionISVStudentInfoDTO（已废弃）
        /// </summary>
        [JsonPropertyName("student_info")]
        public TuitionISVStudentInfoDTO StudentInfo { get; set; }
    }
}
