using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayBossBaseProcessTaskProcessResponse.
    /// </summary>
    public class AlipayBossBaseProcessTaskProcessResponse : AlipayResponse
    {
        /// <summary>
        /// 流程实例数据
        /// </summary>
        [JsonPropertyName("instance")]
        public BPOpenApiInstance Instance { get; set; }
    }
}
