using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniQrcodeUnbindModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniQrcodeUnbindModel : AlipayObject
    {
        /// <summary>
        /// 路由规则组，用于唯一标记一条路由规则。调用 https://opendocs.alipay.com/apis/00rkye 接口关联普通二维码后的返回值。
        /// </summary>
        [JsonPropertyName("route_group")]
        public string RouteGroup { get; set; }
    }
}
