using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// FileInfo Data Structure.
    /// </summary>
    public class FileInfo : AlipayObject
    {
        /// <summary>
        /// 文件类型，唯一值，枚举。 VIDEO=视频;VOICE=语音;PICTURE=图片;TEXT=文本
        /// </summary>
        [JsonPropertyName("data_type")]
        public string DataType { get; set; }

        /// <summary>
        /// 业务素材类型（例如：INTERACTIVE代表交互稿）
        /// </summary>
        [JsonPropertyName("file_biz_type")]
        public string FileBizType { get; set; }

        /// <summary>
        /// 文件地址url
        /// </summary>
        [JsonPropertyName("file_url")]
        public string FileUrl { get; set; }
    }
}
