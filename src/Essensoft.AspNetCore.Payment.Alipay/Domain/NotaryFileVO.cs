using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// NotaryFileVO Data Structure.
    /// </summary>
    public class NotaryFileVO : AlipayObject
    {
        /// <summary>
        /// 文件http地址
        /// </summary>
        [JsonPropertyName("file_addr")]
        public string FileAddr { get; set; }

        /// <summary>
        /// 合同名称
        /// </summary>
        [JsonPropertyName("file_name")]
        public string FileName { get; set; }
    }
}
