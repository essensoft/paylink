using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayInsSceneInsserviceprodSerattachmentDeleteResponse.
    /// </summary>
    public class AlipayInsSceneInsserviceprodSerattachmentDeleteResponse : AlipayResponse
    {
        /// <summary>
        /// 文件编号 (原封不动地把请求中的附件编号返回给你)
        /// </summary>
        [JsonPropertyName("attachment_no")]
        public string AttachmentNo { get; set; }
    }
}
