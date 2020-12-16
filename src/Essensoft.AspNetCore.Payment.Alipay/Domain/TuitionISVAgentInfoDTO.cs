using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TuitionISVAgentInfoDTO Data Structure.
    /// </summary>
    public class TuitionISVAgentInfoDTO : AlipayObject
    {
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
