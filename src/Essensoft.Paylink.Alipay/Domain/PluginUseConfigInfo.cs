using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// PluginUseConfigInfo Data Structure.
    /// </summary>
    public class PluginUseConfigInfo : AlipayObject
    {
        /// <summary>
        /// 端
        /// </summary>
        [JsonPropertyName("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 灰度策略
        /// </summary>
        [JsonPropertyName("gray_code")]
        public string GrayCode { get; set; }

        /// <summary>
        /// 插件研发版本
        /// </summary>
        [JsonPropertyName("plugin_develop_version")]
        public string PluginDevelopVersion { get; set; }

        /// <summary>
        /// GRAY(灰度中)/RELEASE(在线状态)
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
