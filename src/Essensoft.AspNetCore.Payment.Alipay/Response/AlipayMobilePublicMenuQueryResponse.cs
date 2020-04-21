using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMobilePublicMenuQueryResponse.
    /// </summary>
    public class AlipayMobilePublicMenuQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 所有菜单列表json串
        /// </summary>
        [JsonPropertyName("all_menu_list")]
        public string AllMenuList { get; set; }

        /// <summary>
        /// 结果码
        /// </summary>
        [JsonPropertyName("code")]
        public override string Code { get; set; }

        /// <summary>
        /// 结果描述
        /// </summary>
        [JsonPropertyName("msg")]
        public override string Msg { get; set; }
    }
}
