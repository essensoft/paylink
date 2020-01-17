using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Attachment Data Structure.
    /// </summary>
    public class Attachment : AlipayObject
    {
        /// <summary>
        /// 流程附件名称
        /// </summary>
        [JsonPropertyName("attachment_name")]
        public string AttachmentName { get; set; }

        /// <summary>
        /// 流程附件id
        /// </summary>
        [JsonPropertyName("file_id")]
        public string FileId { get; set; }
    }
}
