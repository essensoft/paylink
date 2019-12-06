using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayIserviceCognitiveOcrVehicleplateQueryModel Data Structure.
    /// </summary>
    public class AlipayIserviceCognitiveOcrVehicleplateQueryModel : AlipayObject
    {
        /// <summary>
        /// 车牌图片base64加密后内容
        /// </summary>
        [JsonPropertyName("image_content")]
        public string ImageContent { get; set; }
    }
}
