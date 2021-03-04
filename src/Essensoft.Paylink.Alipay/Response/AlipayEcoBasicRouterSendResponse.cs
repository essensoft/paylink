using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayEcoBasicRouterSendResponse.
    /// </summary>
    public class AlipayEcoBasicRouterSendResponse : AlipayResponse
    {
        /// <summary>
        /// 路由返回的数据
        /// </summary>
        [JsonPropertyName("res")]
        public string Res { get; set; }
    }
}
