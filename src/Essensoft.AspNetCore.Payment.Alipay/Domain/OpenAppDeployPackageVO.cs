using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OpenAppDeployPackageVO Data Structure.
    /// </summary>
    public class OpenAppDeployPackageVO : AlipayObject
    {
        /// <summary>
        /// 发布标识
        /// </summary>
        [JsonPropertyName("deploy_version")]
        public string DeployVersion { get; set; }

        /// <summary>
        /// 小程序ID
        /// </summary>
        [JsonPropertyName("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 普通小程序包地址
        /// </summary>
        [JsonPropertyName("package_url")]
        public string PackageUrl { get; set; }

        /// <summary>
        /// 插件包地址
        /// </summary>
        [JsonPropertyName("plugin_url")]
        public string PluginUrl { get; set; }
    }
}
