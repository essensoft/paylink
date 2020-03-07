using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniQrcodeBindResponse.
    /// </summary>
    public class AlipayOpenMiniQrcodeBindResponse : AlipayResponse
    {
        /// <summary>
        /// 路由规则组，用于唯一标记一条路由规则
        /// </summary>
        [JsonPropertyName("route_group")]
        public string RouteGroup { get; set; }
    }
}
