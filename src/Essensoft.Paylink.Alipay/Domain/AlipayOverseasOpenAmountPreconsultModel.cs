using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayOverseasOpenAmountPreconsultModel Data Structure.
    /// </summary>
    public class AlipayOverseasOpenAmountPreconsultModel : AlipayObject
    {
        /// <summary>
        /// 机构信息
        /// </summary>
        [JsonPropertyName("agent_info")]
        public TuitionISVAgentInfoDTO AgentInfo { get; set; }

        /// <summary>
        /// 原金额
        /// </summary>
        [JsonPropertyName("original_amount")]
        public TuitionMoneyDTO OriginalAmount { get; set; }

        /// <summary>
        /// 外部参考号，由调用方生成
        /// </summary>
        [JsonPropertyName("reference_id")]
        public string ReferenceId { get; set; }
    }
}
