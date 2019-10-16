using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MiniAppVersionInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MiniAppVersionInfo : AlipayObject
    {
        /// <summary>
        /// Android客户端版本号信息
        /// </summary>
        [JsonProperty("android_client_version_info")]
        public MiniAppClientVersionInfo AndroidClientVersionInfo { get; set; }

        /// <summary>
        /// 版本号
        /// </summary>
        [JsonProperty("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 小程序构建日志地址
        /// </summary>
        [JsonProperty("build_task_log")]
        public string BuildTaskLog { get; set; }

        /// <summary>
        /// 覆盖率包信息
        /// </summary>
        [JsonProperty("coverage_package")]
        public MiniAppPackageInfo CoveragePackage { get; set; }

        /// <summary>
        /// 覆盖率完成度
        /// </summary>
        [JsonProperty("coverage_rate")]
        public long CoverageRate { get; set; }

        /// <summary>
        /// 版本生成失败错误原因
        /// </summary>
        [JsonProperty("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// iOS客户端版本号信息
        /// </summary>
        [JsonProperty("ios_client_version_info")]
        public MiniAppClientVersionInfo IosClientVersionInfo { get; set; }

        /// <summary>
        /// 小程序预发包信息
        /// </summary>
        [JsonProperty("preonline_package")]
        public MiniAppPackageInfo PreonlinePackage { get; set; }

        /// <summary>
        /// 安全扫描结果  True:安全扫描通过  False:安全扫描不通过  NAN:扫描中
        /// </summary>
        [JsonProperty("security_scan_result")]
        public string SecurityScanResult { get; set; }

        /// <summary>
        /// 版本状态  PACKAGING:打包中  PACKAGE_FAILED:打包失败  PACKAGE_SUCCEED:打包完成  PACKAGE_DELETED:版本已删除  PRE_ONLINE:预发中  PRE_ONLINE_CONFIRM:预发完成  RELEASE:发布完成  OFFLINE:已下架
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
