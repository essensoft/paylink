using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenPublicMenuQueryResponse.
    /// </summary>
    public class AlipayOpenPublicMenuQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 一级菜单数组，个数应为1~4个
        /// </summary>
        [JsonProperty("menu_content")]
        public string MenuContent { get; set; }
    }
}
