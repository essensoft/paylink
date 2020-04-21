using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MiniAppPluginInfo Data Structure.
    /// </summary>
    public class MiniAppPluginInfo : AlipayObject
    {
        /// <summary>
        /// 插件包地址
        /// </summary>
        [JsonPropertyName("package_url")]
        public string PackageUrl { get; set; }

        /// <summary>
        /// 插件id，即插件的唯一标识
        /// </summary>
        [JsonPropertyName("plugin_id")]
        public string PluginId { get; set; }

        /// <summary>
        /// 小程序引用的插件版本，可以指定插件版本，1.2.3。也可以使用最新版本,*。推荐使用*
        /// </summary>
        [JsonPropertyName("require_version")]
        public string RequireVersion { get; set; }
    }
}
