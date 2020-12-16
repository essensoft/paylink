using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ContractFileVO Data Structure.
    /// </summary>
    public class ContractFileVO : AlipayObject
    {
        /// <summary>
        /// 文件地址
        /// </summary>
        [JsonPropertyName("file_addr")]
        public string FileAddr { get; set; }

        /// <summary>
        /// 文件名称
        /// </summary>
        [JsonPropertyName("file_name")]
        public string FileName { get; set; }
    }
}
