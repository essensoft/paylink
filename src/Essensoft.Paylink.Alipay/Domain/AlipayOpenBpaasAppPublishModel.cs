using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenBpaasAppPublishModel Data Structure.
    /// </summary>
    public class AlipayOpenBpaasAppPublishModel : AlipayObject
    {
        /// <summary>
        /// 应用版本号, 要求为纯数字，如10.20.1.1等 必须4位
        /// </summary>
        [JsonPropertyName("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// bpaas 应用id
        /// </summary>
        [JsonPropertyName("bpaas_app_id")]
        public string BpaasAppId { get; set; }

        /// <summary>
        /// 应用版本变更记录
        /// </summary>
        [JsonPropertyName("change_log")]
        public string ChangeLog { get; set; }

        /// <summary>
        /// 文件SHA256摘要信息
        /// </summary>
        [JsonPropertyName("file_digest")]
        public string FileDigest { get; set; }

        /// <summary>
        /// 文件MD5值
        /// </summary>
        [JsonPropertyName("file_md_5")]
        public string FileMd5 { get; set; }

        /// <summary>
        /// 应用包文件大小
        /// </summary>
        [JsonPropertyName("package_file_size")]
        public long PackageFileSize { get; set; }

        /// <summary>
        /// 应用包下载地址，公开url
        /// </summary>
        [JsonPropertyName("scm_download_url")]
        public string ScmDownloadUrl { get; set; }
    }
}
