using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ContractManagerSignDocsRequest Data Structure.
    /// </summary>
    public class ContractManagerSignDocsRequest : AlipayObject
    {
        /// <summary>
        /// 签署文件fileId
        /// </summary>
        [JsonPropertyName("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 签署文档文件
        /// </summary>
        [JsonPropertyName("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// 签署文档总页数
        /// </summary>
        [JsonPropertyName("total_page")]
        public string TotalPage { get; set; }
    }
}
