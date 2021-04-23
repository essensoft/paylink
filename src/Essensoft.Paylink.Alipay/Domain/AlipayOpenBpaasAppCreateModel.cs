using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenBpaasAppCreateModel Data Structure.
    /// </summary>
    public class AlipayOpenBpaasAppCreateModel : AlipayObject
    {
        /// <summary>
        /// 应用icon 链接下载地址
        /// </summary>
        [JsonPropertyName("app_icon_url")]
        public string AppIconUrl { get; set; }

        /// <summary>
        /// 应用介绍
        /// </summary>
        [JsonPropertyName("app_introduction")]
        public string AppIntroduction { get; set; }

        /// <summary>
        /// 应用名称
        /// </summary>
        [JsonPropertyName("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 可选参数，ANDROID应用为必填项
        /// </summary>
        [JsonPropertyName("app_package")]
        public string AppPackage { get; set; }

        /// <summary>
        /// 应用平台，native应用类型支持ANDROID、ROTS、LINUX、WINDOWS
        /// </summary>
        [JsonPropertyName("app_platform")]
        public string AppPlatform { get; set; }

        /// <summary>
        /// 应用签名
        /// </summary>
        [JsonPropertyName("app_sign")]
        public string AppSign { get; set; }

        /// <summary>
        /// 应用类型，IOT_BPAAS_MOBILE
        /// </summary>
        [JsonPropertyName("app_type")]
        public string AppType { get; set; }
    }
}
