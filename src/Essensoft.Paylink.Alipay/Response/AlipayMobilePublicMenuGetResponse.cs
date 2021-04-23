using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayMobilePublicMenuGetResponse.
    /// </summary>
    public class AlipayMobilePublicMenuGetResponse : AlipayResponse
    {
        /// <summary>
        /// success
        /// </summary>
        [JsonPropertyName("code")]
        public new string Code { get; set; }

        /// <summary>
        /// 菜单内容
        /// </summary>
        [JsonPropertyName("menu_content")]
        public string MenuContent { get; set; }

        /// <summary>
        /// 成功
        /// </summary>
        [JsonPropertyName("msg")]
        public new string Msg { get; set; }
    }
}
