using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// VoucherFileInfo Data Structure.
    /// </summary>
    public class VoucherFileInfo : AlipayObject
    {
        /// <summary>
        /// 发票文件下载
        /// </summary>
        [JsonPropertyName("file_download_url")]
        public string FileDownloadUrl { get; set; }

        /// <summary>
        /// 文件名
        /// </summary>
        [JsonPropertyName("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// 文件类型
        /// </summary>
        [JsonPropertyName("file_type")]
        public string FileType { get; set; }
    }
}
