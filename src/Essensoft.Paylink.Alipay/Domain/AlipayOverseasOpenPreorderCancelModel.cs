using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayOverseasOpenPreorderCancelModel Data Structure.
    /// </summary>
    public class AlipayOverseasOpenPreorderCancelModel : AlipayObject
    {
        /// <summary>
        /// 机构信息
        /// </summary>
        [JsonPropertyName("agent_info")]
        public TuitionISVAgentInfoDTO AgentInfo { get; set; }

        /// <summary>
        /// 单号
        /// </summary>
        [JsonPropertyName("pre_order_id")]
        public string PreOrderId { get; set; }
    }
}
