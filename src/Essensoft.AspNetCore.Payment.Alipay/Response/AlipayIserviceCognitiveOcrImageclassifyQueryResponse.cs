using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayIserviceCognitiveOcrImageclassifyQueryResponse.
    /// </summary>
    public class AlipayIserviceCognitiveOcrImageclassifyQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 图像分类类型
        /// </summary>
        [JsonPropertyName("image_type")]
        public string ImageType { get; set; }
    }
}
