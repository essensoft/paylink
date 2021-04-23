using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// TuitionISVAgentInfoDTO Data Structure.
    /// </summary>
    public class TuitionISVAgentInfoDTO : AlipayObject
    {
        /// <summary>
        /// 二级机构名称
        /// </summary>
        [JsonPropertyName("agent_sub_name")]
        public string AgentSubName { get; set; }

        /// <summary>
        /// 机构isv机构pid
        /// </summary>
        [JsonPropertyName("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// isv机构sub pid
        /// </summary>
        [JsonPropertyName("sub_pid")]
        public string SubPid { get; set; }
    }
}
