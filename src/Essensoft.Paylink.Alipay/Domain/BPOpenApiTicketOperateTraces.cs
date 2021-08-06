using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// BPOpenApiTicketOperateTraces Data Structure.
    /// </summary>
    public class BPOpenApiTicketOperateTraces : AlipayObject
    {
        /// <summary>
        /// 操作记录
        /// </summary>
        [JsonPropertyName("operate_traces")]
        public List<BPOpenApiTicketOperateTrace> OperateTraces { get; set; }
    }
}
