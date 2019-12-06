using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringTablecodeQueryModel Data Structure.
    /// </summary>
    public class KoubeiCateringTablecodeQueryModel : AlipayObject
    {
        /// <summary>
        /// 用户在isv界面通过扫一扫传入的url文本
        /// </summary>
        [JsonPropertyName("url_context")]
        public string UrlContext { get; set; }
    }
}
