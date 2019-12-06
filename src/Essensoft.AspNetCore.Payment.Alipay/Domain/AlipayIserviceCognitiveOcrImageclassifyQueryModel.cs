using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayIserviceCognitiveOcrImageclassifyQueryModel Data Structure.
    /// </summary>
    public class AlipayIserviceCognitiveOcrImageclassifyQueryModel : AlipayObject
    {
        /// <summary>
        /// 图片base64加密后的内容，大小控制在1.5M
        /// </summary>
        [JsonPropertyName("image_content")]
        public string ImageContent { get; set; }
    }
}
