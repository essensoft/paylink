using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// FixFileInfo Data Structure.
    /// </summary>
    public class FixFileInfo : AlipayObject
    {
        /// <summary>
        /// 附件的下载地址
        /// </summary>
        [JsonPropertyName("download_url")]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// 文件的id
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// 文件名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 文件类型。枚举，image:图片;video:视频
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
