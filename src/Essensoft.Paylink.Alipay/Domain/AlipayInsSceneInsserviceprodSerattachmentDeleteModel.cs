using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayInsSceneInsserviceprodSerattachmentDeleteModel Data Structure.
    /// </summary>
    public class AlipayInsSceneInsserviceprodSerattachmentDeleteModel : AlipayObject
    {
        /// <summary>
        /// 待撤回的文件编号 （本字段也就是上传附件接口返回的那个附件ID）
        /// </summary>
        [JsonPropertyName("attachment_no")]
        public string AttachmentNo { get; set; }
    }
}
