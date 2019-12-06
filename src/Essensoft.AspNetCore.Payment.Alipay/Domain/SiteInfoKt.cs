using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SiteInfoKt Data Structure.
    /// </summary>
    public class SiteInfoKt : AlipayObject
    {
        /// <summary>
        /// 测试账号
        /// </summary>
        [JsonPropertyName("account")]
        public string Account { get; set; }

        /// <summary>
        /// 测试密码
        /// </summary>
        [JsonPropertyName("password")]
        public string Password { get; set; }

        /// <summary>
        /// 站点名称
        /// </summary>
        [JsonPropertyName("site_name")]
        public string SiteName { get; set; }

        /// <summary>
        /// 网站：01&#160;&#8232;APP : 02&#160;&#8232;服务窗:03&#160;&#8232;公众号:04&#160;&#8232;其他:05&#160;&#8232;支付宝小程序:06
        /// </summary>
        [JsonPropertyName("site_type")]
        public string SiteType { get; set; }

        /// <summary>
        /// 站点地址
        /// </summary>
        [JsonPropertyName("site_url")]
        public string SiteUrl { get; set; }
    }
}
