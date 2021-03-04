using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayBossBaseProcessInstanceCreateResponse.
    /// </summary>
    public class AlipayBossBaseProcessInstanceCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 创建的实例
        /// </summary>
        [JsonPropertyName("instance")]
        public BPOpenApiInstance Instance { get; set; }
    }
}
