using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SignedFileInfo Data Structure.
    /// </summary>
    public class SignedFileInfo : AlipayObject
    {
        /// <summary>
        /// 文档过期时间戳
        /// </summary>
        [JsonPropertyName("expired_time")]
        public string ExpiredTime { get; set; }

        /// <summary>
        /// 数据名
        /// </summary>
        [JsonPropertyName("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// 文件类型  pdf //pdf文档  p7 //pkcs7签名文档
        /// </summary>
        [JsonPropertyName("file_type")]
        public string FileType { get; set; }

        /// <summary>
        /// 文件读取url地址
        /// </summary>
        [JsonPropertyName("file_url")]
        public string FileUrl { get; set; }

        /// <summary>
        /// 文档创建时间戳
        /// </summary>
        [JsonPropertyName("gmt_time")]
        public string GmtTime { get; set; }

        /// <summary>
        /// 签约数据编号，由平台生成
        /// </summary>
        [JsonPropertyName("inner_data_id")]
        public string InnerDataId { get; set; }

        /// <summary>
        /// 签约数据编号，由外部系统定义，用于数据关联
        /// </summary>
        [JsonPropertyName("out_data_id")]
        public string OutDataId { get; set; }

        /// <summary>
        /// 文档签名结果
        /// </summary>
        [JsonPropertyName("signed_data")]
        public string SignedData { get; set; }

        /// <summary>
        /// 资源文件类型  DATA //文件原文  FILE  //文件OSS索引
        /// </summary>
        [JsonPropertyName("source_type")]
        public string SourceType { get; set; }
    }
}
