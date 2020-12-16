using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOverseasTransferPaymentNotifyModel Data Structure.
    /// </summary>
    public class AlipayOverseasTransferPaymentNotifyModel : AlipayObject
    {
        /// <summary>
        /// Only used for pass-through. In JSON map format.
        /// </summary>
        [JsonPropertyName("pass_through_info")]
        public string PassThroughInfo { get; set; }

        /// <summary>
        /// 发端机构
        /// </summary>
        [JsonPropertyName("payer_agent_id")]
        public string PayerAgentId { get; set; }

        /// <summary>
        /// 交易流水号
        /// </summary>
        [JsonPropertyName("transfer_request_id")]
        public string TransferRequestId { get; set; }
    }
}
