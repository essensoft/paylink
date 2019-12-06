using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayIserviceCognitiveOcrIdcardQueryModel Data Structure.
    /// </summary>
    public class AlipayIserviceCognitiveOcrIdcardQueryModel : AlipayObject
    {
        /// <summary>
        /// 身份证图片base64编码内容
        /// </summary>
        [JsonPropertyName("image_content")]
        public string ImageContent { get; set; }

        /// <summary>
        /// face: 身份证正面  back: 身份证反面  缺省值是：face
        /// </summary>
        [JsonPropertyName("side")]
        public string Side { get; set; }
    }
}
