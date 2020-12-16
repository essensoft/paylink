using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOverseasTransferPaymentQueryModel Data Structure.
    /// </summary>
    public class AlipayOverseasTransferPaymentQueryModel : AlipayObject
    {
        /// <summary>
        /// 透出字段。以map方式存储
        /// </summary>
        [JsonPropertyName("pass_through_info")]
        public string PassThroughInfo { get; set; }

        /// <summary>
        /// 源机构编号
        /// </summary>
        [JsonPropertyName("payer_agent_id")]
        public string PayerAgentId { get; set; }

        /// <summary>
        /// AC交易流水号
        /// </summary>
        [JsonPropertyName("transfer_request_id")]
        public string TransferRequestId { get; set; }
    }
}
