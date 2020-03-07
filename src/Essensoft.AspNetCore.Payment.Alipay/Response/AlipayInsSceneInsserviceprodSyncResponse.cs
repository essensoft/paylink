using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayInsSceneInsserviceprodSyncResponse.
    /// </summary>
    public class AlipayInsSceneInsserviceprodSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 节点描述信息
        /// </summary>
        [JsonPropertyName("node_desc")]
        public string NodeDesc { get; set; }

        /// <summary>
        /// 节点名称
        /// </summary>
        [JsonPropertyName("node_name")]
        public string NodeName { get; set; }
    }
}
