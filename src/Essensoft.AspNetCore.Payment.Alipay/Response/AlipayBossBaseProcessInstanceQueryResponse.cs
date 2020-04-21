using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayBossBaseProcessInstanceQueryResponse.
    /// </summary>
    public class AlipayBossBaseProcessInstanceQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 流程实例内容
        /// </summary>
        [JsonPropertyName("instance")]
        public BPOpenApiInstance Instance { get; set; }
    }
}
