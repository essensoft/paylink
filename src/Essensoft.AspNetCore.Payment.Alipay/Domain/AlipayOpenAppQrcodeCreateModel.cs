using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppQrcodeCreateModel Data Structure.
    /// </summary>
    public class AlipayOpenAppQrcodeCreateModel : AlipayObject
    {
        /// <summary>
        /// 对应的二维码描述
        /// </summary>
        [JsonPropertyName("describe")]
        public string Describe { get; set; }

        /// <summary>
        /// 小程序的启动参数，打开小程序的query ，在小程序 onLaunch的方法中获取
        /// </summary>
        [JsonPropertyName("query_param")]
        public string QueryParam { get; set; }

        /// <summary>
        /// page/component/component-pages/view/view为小程序中能访问到的页面路径
        /// </summary>
        [JsonPropertyName("url_param")]
        public string UrlParam { get; set; }
    }
}
