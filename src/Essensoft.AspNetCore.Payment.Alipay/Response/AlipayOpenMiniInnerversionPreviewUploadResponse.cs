using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniInnerversionPreviewUploadResponse.
    /// </summary>
    public class AlipayOpenMiniInnerversionPreviewUploadResponse : AlipayResponse
    {
        /// <summary>
        /// 构建好的包地址
        /// </summary>
        [JsonPropertyName("build_package_url")]
        public string BuildPackageUrl { get; set; }

        /// <summary>
        /// 部署版本号，一个应用、租户、端在应用中心唯一的一条发布记录版本号、
        /// </summary>
        [JsonPropertyName("deploy_version")]
        public string DeployVersion { get; set; }
    }
}
