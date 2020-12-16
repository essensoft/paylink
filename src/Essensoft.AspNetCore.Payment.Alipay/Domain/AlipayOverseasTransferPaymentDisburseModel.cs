using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOverseasTransferPaymentDisburseModel Data Structure.
    /// </summary>
    public class AlipayOverseasTransferPaymentDisburseModel : AlipayObject
    {
        /// <summary>
        /// 透传信息
        /// </summary>
        [JsonPropertyName("pass_through_info")]
        public string PassThroughInfo { get; set; }

        /// <summary>
        /// 发端机构
        /// </summary>
        [JsonPropertyName("payer_agent_id")]
        public string PayerAgentId { get; set; }

        /// <summary>
        /// 批量请求接口，目前仅支持单笔能力
        /// </summary>
        [JsonPropertyName("transactions")]
        public string Transactions { get; set; }
    }
}
