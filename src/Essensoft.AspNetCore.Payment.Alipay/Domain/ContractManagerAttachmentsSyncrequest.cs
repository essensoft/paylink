using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ContractManagerAttachmentsSyncrequest Data Structure.
    /// </summary>
    public class ContractManagerAttachmentsSyncrequest : AlipayObject
    {
        /// <summary>
        /// 附件fileId
        /// </summary>
        [JsonPropertyName("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 附件名称
        /// </summary>
        [JsonPropertyName("file_name")]
        public string FileName { get; set; }
    }
}
