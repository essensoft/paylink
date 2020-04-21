using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayPaiPartnerResultGetResponse.
    /// </summary>
    public class AlipayPaiPartnerResultGetResponse : AlipayResponse
    {
        /// <summary>
        /// 路由协议内容,根据不同的协议数据不一样
        /// </summary>
        [JsonPropertyName("data")]
        public string Data { get; set; }

        /// <summary>
        /// 为新浪用户申请的 authToken 访问商品码wap页面时需要使用
        /// </summary>
        [JsonPropertyName("oauth_token")]
        public string OauthToken { get; set; }

        /// <summary>
        /// 码协议：MSPAY（快捷支付） WEBVIEW(内置浏览器打开wap) NATIVE(本地打开app) WEB(外置浏览器打开)
        /// </summary>
        [JsonPropertyName("route_method")]
        public string RouteMethod { get; set; }
    }
}
