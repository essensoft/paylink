using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayInsSceneInsserviceprodSerattachmentUploadResponse.
    /// </summary>
    public class AlipayInsSceneInsserviceprodSerattachmentUploadResponse : AlipayResponse
    {
        /// <summary>
        /// 附件编号(业务主键)
        /// </summary>
        [JsonPropertyName("attachment_no")]
        public string AttachmentNo { get; set; }
    }
}
