using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayIserviceCognitiveOcrBusinesslicenseQueryModel Data Structure.
    /// </summary>
    public class AlipayIserviceCognitiveOcrBusinesslicenseQueryModel : AlipayObject
    {
        /// <summary>
        /// 营业执照图片base64加密后内容
        /// </summary>
        [JsonPropertyName("image_content")]
        public string ImageContent { get; set; }
    }
}
