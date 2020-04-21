using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayIserviceCognitiveOcrDriverlicenseQueryModel Data Structure.
    /// </summary>
    public class AlipayIserviceCognitiveOcrDriverlicenseQueryModel : AlipayObject
    {
        /// <summary>
        /// 驾驶证图片base64加密后内容，大小控制在1.5M以内
        /// </summary>
        [JsonPropertyName("image_content")]
        public string ImageContent { get; set; }
    }
}
