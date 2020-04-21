using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniInnerversionUploadstatusQueryResponse.
    /// </summary>
    public class AlipayOpenMiniInnerversionUploadstatusQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 构建信息
        /// </summary>
        [JsonPropertyName("build_info")]
        public string BuildInfo { get; set; }

        /// <summary>
        /// 构建好的包地址
        /// </summary>
        [JsonPropertyName("build_package_url")]
        public string BuildPackageUrl { get; set; }

        /// <summary>
        /// 构建状态
        /// </summary>
        [JsonPropertyName("build_status")]
        public string BuildStatus { get; set; }

        /// <summary>
        /// 构建日志地址
        /// </summary>
        [JsonPropertyName("log_url")]
        public string LogUrl { get; set; }

        /// <summary>
        /// 是否需要轮询
        /// </summary>
        [JsonPropertyName("need_rotation")]
        public string NeedRotation { get; set; }

        /// <summary>
        /// 构建的结果地址
        /// </summary>
        [JsonPropertyName("result_url")]
        public string ResultUrl { get; set; }

        /// <summary>
        /// 创建版本结果
        /// </summary>
        [JsonPropertyName("version_created")]
        public string VersionCreated { get; set; }
    }
}
