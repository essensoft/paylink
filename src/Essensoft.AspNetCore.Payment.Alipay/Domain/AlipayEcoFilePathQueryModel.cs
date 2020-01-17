using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoFilePathQueryModel Data Structure.
    /// </summary>
    public class AlipayEcoFilePathQueryModel : AlipayObject
    {
        /// <summary>
        /// 先计算文件md5值，在对该md5值进行base64编码
        /// </summary>
        [JsonPropertyName("content_md_5")]
        public string ContentMd5 { get; set; }

        /// <summary>
        /// 目标文件的MIME类型
        /// </summary>
        [JsonPropertyName("content_type")]
        public string ContentType { get; set; }

        /// <summary>
        /// 文件名称（必须带上文件扩展名，不然会导致后续发起流程校验过不去 示例：合同.pdf ）
        /// </summary>
        [JsonPropertyName("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// 文件大小，单位byte。最大允许上传30Mb
        /// </summary>
        [JsonPropertyName("file_size")]
        public long FileSize { get; set; }
    }
}
