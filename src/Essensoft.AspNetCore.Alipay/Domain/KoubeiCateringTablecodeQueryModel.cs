using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringTablecodeQueryModel Data Structure.
    /// </summary>
    public class KoubeiCateringTablecodeQueryModel : AlipayObject
    {
        /// <summary>
        /// 用户在isv界面通过扫一扫传入的url文本
        /// </summary>
        [JsonProperty("url_context")]
        public string UrlContext { get; set; }
    }
}
