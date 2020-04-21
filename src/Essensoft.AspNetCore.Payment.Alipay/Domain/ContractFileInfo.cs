using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ContractFileInfo Data Structure.
    /// </summary>
    public class ContractFileInfo : AlipayObject
    {
        /// <summary>
        /// 合同文件名称
        /// </summary>
        [JsonPropertyName("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// 合同文件url
        /// </summary>
        [JsonPropertyName("file_url")]
        public string FileUrl { get; set; }
    }
}
