using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerversionUploadModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniInnerversionUploadModel : AlipayObject
    {
        /// <summary>
        /// 业务来源，新接入方需要向支付宝申请专用来源，否则不予接入。https://yuque.antfin-inc.com/tinyapp-all/qddncu/bidushixiang
        /// </summary>
        [JsonPropertyName("app_origin")]
        public string AppOrigin { get; set; }

        /// <summary>
        /// IDE开发打包类型，写死tinyApp
        /// </summary>
        [JsonPropertyName("build_app_type")]
        public string BuildAppType { get; set; }

        /// <summary>
        /// 扩展信息，比如adaptorName、tinycliVersion、tinycliName、import-module、allowPrecompile、extJson、allowInstallDependency、aggregationMainAppId，如果没有特殊要求，tinycliVersion版本请用最新的： https://registry.npm.alibaba-inc.com/@alipay/tiny-cli/huoban-prod
        /// </summary>
        [JsonPropertyName("build_extra_info")]
        public string BuildExtraInfo { get; set; }

        /// <summary>
        /// jsapi 权限文件,钉钉外请勿传
        /// </summary>
        [JsonPropertyName("build_js_permission")]
        public string BuildJsPermission { get; set; }

        /// <summary>
        /// 小程序页面主入口。/index.html#page/component/index，该值需要和extendInfo中的page参数保持一致
        /// </summary>
        [JsonPropertyName("build_main_url")]
        public string BuildMainUrl { get; set; }

        /// <summary>
        /// 最大Android客户端版本号，禁止使用，如果需要使用请联系小程序平台评估，否则端上会出现问题
        /// </summary>
        [JsonPropertyName("build_max_android_client_version")]
        public string BuildMaxAndroidClientVersion { get; set; }

        /// <summary>
        /// 最大iOS客户单版本号，禁止使用，如果需要使用请联系小程序平台评估，否则端上会出现问题
        /// </summary>
        [JsonPropertyName("build_max_ios_client_version")]
        public string BuildMaxIosClientVersion { get; set; }

        /// <summary>
        /// 最小Android客户端版本号，禁止使用，如果需要使用请联系小程序平台评估，否则端上会出现问题
        /// </summary>
        [JsonPropertyName("build_min_android_client_version")]
        public string BuildMinAndroidClientVersion { get; set; }

        /// <summary>
        /// 最小iOS客户单版本号，禁止使用，如果需要使用请联系小程序平台评估，否则端上会出现问题
        /// </summary>
        [JsonPropertyName("build_min_ios_client_version")]
        public string BuildMinIosClientVersion { get; set; }

        /// <summary>
        /// 源码包文件流的MD5字符串
        /// </summary>
        [JsonPropertyName("build_package_md_5")]
        public string BuildPackageMd5 { get; set; }

        /// <summary>
        /// 包名称
        /// </summary>
        [JsonPropertyName("build_package_name")]
        public string BuildPackageName { get; set; }

        /// <summary>
        /// base64编码后的小程序源码包文件流
        /// </summary>
        [JsonPropertyName("build_package_stream")]
        public string BuildPackageStream { get; set; }

        /// <summary>
        /// 打包平台扩展信息
        /// </summary>
        [JsonPropertyName("build_qcloud_info")]
        public string BuildQcloudInfo { get; set; }

        /// <summary>
        /// 已经构建加签过的包地址
        /// </summary>
        [JsonPropertyName("build_signed_pkg_url")]
        public string BuildSignedPkgUrl { get; set; }

        /// <summary>
        /// 源码包大小
        /// </summary>
        [JsonPropertyName("build_source_pkg_size")]
        public string BuildSourcePkgSize { get; set; }

        /// <summary>
        /// 源码包地址，源码包大小不能超过20M且地址必须永久有效，若超20M，将限制业务来源调用。将源码文件夹整个用zip格式压缩成后缀amr文件传至文件服务器
        /// </summary>
        [JsonPropertyName("build_source_pkg_url")]
        public string BuildSourcePkgUrl { get; set; }

        /// <summary>
        /// 子入口
        /// </summary>
        [JsonPropertyName("build_sub_url")]
        public string BuildSubUrl { get; set; }

        /// <summary>
        /// 小程序版本
        /// </summary>
        [JsonPropertyName("build_version")]
        public string BuildVersion { get; set; }

        /// <summary>
        /// 一个端的标识，用于区分不同的客户端，每接入一个客户端，都需要向小程序应用中心申请bundleId入驻
        /// </summary>
        [JsonPropertyName("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 多端类型，除了钉钉外其他业务方禁止使用
        /// </summary>
        [JsonPropertyName("client_type")]
        public string ClientType { get; set; }

        /// <summary>
        /// 上传调试版的接入租户类型。
        /// </summary>
        [JsonPropertyName("inst_code")]
        public string InstCode { get; set; }

        /// <summary>
        /// 小程序ID
        /// </summary>
        [JsonPropertyName("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 小程序代码中引用的插件列表，包含插件id和插件版本信息，业务方需要自行解析源码包的app.json里面的plugins信息
        /// </summary>
        [JsonPropertyName("plugin_refs")]
        public List<MiniAppPluginReference> PluginRefs { get; set; }
    }
}
