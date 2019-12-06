using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayIserviceCognitiveInvoicesInferenceQueryModel Data Structure.
    /// </summary>
    public class AlipayIserviceCognitiveInvoicesInferenceQueryModel : AlipayObject
    {
        /// <summary>
        /// 图片文件类型，pdf或jpg，默认pdf
        /// </summary>
        [JsonPropertyName("file_type")]
        public string FileType { get; set; }

        /// <summary>
        /// 图片base64加密后的内容
        /// </summary>
        [JsonPropertyName("img_content")]
        public string ImgContent { get; set; }
    }
}
