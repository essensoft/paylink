using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenPublicPersonalizedMenuCreateResponse.
    /// </summary>
    public class AlipayOpenPublicPersonalizedMenuCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 该套个性化菜单key
        /// </summary>
        [JsonPropertyName("menu_key")]
        public string MenuKey { get; set; }
    }
}
