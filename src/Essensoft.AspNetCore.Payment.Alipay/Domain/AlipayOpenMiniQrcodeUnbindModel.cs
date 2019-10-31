using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniQrcodeUnbindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniQrcodeUnbindModel : AlipayObject
    {
        /// <summary>
        /// 路由规则组，用于唯一标记一条路由规则
        /// </summary>
        [JsonProperty("route_group")]
        public string RouteGroup { get; set; }
    }
}
