using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniInnerversionUploadResponse.
    /// </summary>
    public class AlipayOpenMiniInnerversionUploadResponse : AlipayResponse
    {
        /// <summary>
        /// 构建信息
        /// </summary>
        [JsonPropertyName("build_info")]
        public string BuildInfo { get; set; }

        /// <summary>
        /// 包地址
        /// </summary>
        [JsonPropertyName("build_package_url")]
        public string BuildPackageUrl { get; set; }

        /// <summary>
        /// 构建状态
        /// </summary>
        [JsonPropertyName("build_status")]
        public string BuildStatus { get; set; }

        /// <summary>
        /// 构建版本
        /// </summary>
        [JsonPropertyName("build_version")]
        public string BuildVersion { get; set; }

        /// <summary>
        /// 是否需要轮询
        /// </summary>
        [JsonPropertyName("need_rotation")]
        public string NeedRotation { get; set; }

        /// <summary>
        /// 包管理包ID
        /// </summary>
        [JsonPropertyName("package_id")]
        public string PackageId { get; set; }

        /// <summary>
        /// 版本创建结果
        /// </summary>
        [JsonPropertyName("version_created")]
        public string VersionCreated { get; set; }
    }
}
