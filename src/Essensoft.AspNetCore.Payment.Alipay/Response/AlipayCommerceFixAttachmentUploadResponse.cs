using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceFixAttachmentUploadResponse.
    /// </summary>
    public class AlipayCommerceFixAttachmentUploadResponse : AlipayResponse
    {
        /// <summary>
        /// 上传文件的内容。
        /// </summary>
        [JsonPropertyName("file_info")]
        public FixFileInfo FileInfo { get; set; }
    }
}
