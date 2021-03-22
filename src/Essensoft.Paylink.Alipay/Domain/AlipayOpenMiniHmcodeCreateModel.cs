using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniHmcodeCreateModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniHmcodeCreateModel : AlipayObject
    {
        /// <summary>
        /// 对应的异形码描述
        /// </summary>
        [JsonPropertyName("describe")]
        public string Describe { get; set; }

        /// <summary>
        /// 异形码背景色（点阵颜色），ARGB格式，如#00FFFFFF，以#开头的8位16进制数，前两位是透明度，00-FF，后面6位是RGB颜色取值000000-FFFFFF
        /// </summary>
        [JsonPropertyName("hm_bg_color")]
        public string HmBgColor { get; set; }

        /// <summary>
        /// 异形码前景色（点阵颜色），ARGB格式，如#00FFFFFF，以#开头的8位16进制数，前两位是透明度，00-FF，后面6位是RGB颜色取值000000-FFFFFF
        /// </summary>
        [JsonPropertyName("hm_front_color")]
        public string HmFrontColor { get; set; }

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
