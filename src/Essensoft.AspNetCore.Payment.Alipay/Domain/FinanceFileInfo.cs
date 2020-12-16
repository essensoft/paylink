using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// FinanceFileInfo Data Structure.
    /// </summary>
    public class FinanceFileInfo : AlipayObject
    {
        /// <summary>
        /// 文件内容hash
        /// </summary>
        [JsonPropertyName("file_hash")]
        public string FileHash { get; set; }

        /// <summary>
        /// 上传文件生成的唯一id
        /// </summary>
        [JsonPropertyName("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 用于路由文件路径的key
        /// </summary>
        [JsonPropertyName("file_key")]
        public string FileKey { get; set; }
    }
}
