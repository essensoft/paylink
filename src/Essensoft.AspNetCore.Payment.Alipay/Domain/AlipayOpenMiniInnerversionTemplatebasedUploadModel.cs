using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerversionTemplatebasedUploadModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniInnerversionTemplatebasedUploadModel : AlipayObject
    {
        /// <summary>
        /// 版本号
        /// </summary>
        [JsonPropertyName("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 构建拓展参数
        /// </summary>
        [JsonPropertyName("build_extra_info")]
        public string BuildExtraInfo { get; set; }

        /// <summary>
        /// 构建方式TEMPLATE_CONFIG_PKG：模板配置化；TEMPLATE_EXTEND：模板继承
        /// </summary>
        [JsonPropertyName("build_type")]
        public string BuildType { get; set; }

        /// <summary>
        /// 淘宝：com.taobao.app
        /// </summary>
        [JsonPropertyName("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 租户编码
        /// </summary>
        [JsonPropertyName("inst_code")]
        public string InstCode { get; set; }

        /// <summary>
        /// 小程序ID
        /// </summary>
        [JsonPropertyName("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 端标识
        /// </summary>
        [JsonPropertyName("template_bundle_id")]
        public string TemplateBundleId { get; set; }

        /// <summary>
        /// 模板ID
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 版本号
        /// </summary>
        [JsonPropertyName("template_version")]
        public string TemplateVersion { get; set; }

        /// <summary>
        /// 模板实例化后版本的状态，当前支持实例化后的版本为初始化状态（INIT），或直接上架（RELEASE），不传默认为INIT
        /// </summary>
        [JsonPropertyName("version_status")]
        public string VersionStatus { get; set; }
    }
}
