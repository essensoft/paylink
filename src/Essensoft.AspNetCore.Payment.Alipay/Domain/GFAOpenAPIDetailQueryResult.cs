using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// GFAOpenAPIDetailQueryResult Data Structure.
    /// </summary>
    public class GFAOpenAPIDetailQueryResult : AlipayObject
    {
        /// <summary>
        /// 业财受理单基础模型
        /// </summary>
        [JsonPropertyName("acceptance_list")]
        public List<GFAOpenAPIBaseAcceptance> AcceptanceList { get; set; }

        /// <summary>
        /// 业财受理指令
        /// </summary>
        [JsonPropertyName("command_list")]
        public List<GFAOpenAPICommand> CommandList { get; set; }
    }
}
