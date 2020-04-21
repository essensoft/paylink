using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoBasicRouterSendModel Data Structure.
    /// </summary>
    public class AlipayEcoBasicRouterSendModel : AlipayObject
    {
        /// <summary>
        /// 路由数据
        /// </summary>
        [JsonPropertyName("input")]
        public string Input { get; set; }

        /// <summary>
        /// 路由任务名
        /// </summary>
        [JsonPropertyName("interface_name")]
        public string InterfaceName { get; set; }

        /// <summary>
        /// 本次调用唯一id
        /// </summary>
        [JsonPropertyName("trace_id")]
        public string TraceId { get; set; }
    }
}
