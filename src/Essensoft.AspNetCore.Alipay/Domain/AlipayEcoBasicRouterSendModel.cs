using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoBasicRouterSendModel Data Structure.
    /// </summary>
    public class AlipayEcoBasicRouterSendModel : AlipayObject
    {
        /// <summary>
        /// 路由数据
        /// </summary>
        [JsonProperty("input")]
        public string Input { get; set; }

        /// <summary>
        /// 路由任务名
        /// </summary>
        [JsonProperty("interface_name")]
        public string InterfaceName { get; set; }

        /// <summary>
        /// 本次调用唯一id
        /// </summary>
        [JsonProperty("trace_id")]
        public string TraceId { get; set; }
    }
}
