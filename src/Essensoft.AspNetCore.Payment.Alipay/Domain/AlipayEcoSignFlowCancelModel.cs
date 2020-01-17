using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoSignFlowCancelModel Data Structure.
    /// </summary>
    public class AlipayEcoSignFlowCancelModel : AlipayObject
    {
        /// <summary>
        /// 流程id
        /// </summary>
        [JsonPropertyName("flow_id")]
        public string FlowId { get; set; }

        /// <summary>
        /// 撤销原因,默认"撤销"
        /// </summary>
        [JsonPropertyName("revoke_reason")]
        public string RevokeReason { get; set; }
    }
}
