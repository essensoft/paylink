using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayBossBaseInstanceOperatetraceQueryResponse.
    /// </summary>
    public class AlipayBossBaseInstanceOperatetraceQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 操作记录
        /// </summary>
        [JsonPropertyName("operate_traces")]
        public BPOpenApiTicketOperateTraces OperateTraces { get; set; }
    }
}
