using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOverseasTransferPaymentCancelModel Data Structure.
    /// </summary>
    public class AlipayOverseasTransferPaymentCancelModel : AlipayObject
    {
        /// <summary>
        /// Cancelation reason
        /// </summary>
        [JsonPropertyName("cancel_reason")]
        public string CancelReason { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [JsonPropertyName("pass_through_info")]
        public string PassThroughInfo { get; set; }

        /// <summary>
        /// 发端机构
        /// </summary>
        [JsonPropertyName("payer_agent_id")]
        public string PayerAgentId { get; set; }

        /// <summary>
        /// AC请求单号
        /// </summary>
        [JsonPropertyName("transfer_request_id")]
        public string TransferRequestId { get; set; }
    }
}
