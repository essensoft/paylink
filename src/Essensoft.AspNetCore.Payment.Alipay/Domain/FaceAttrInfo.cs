using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// FaceAttrInfo Data Structure.
    /// </summary>
    public class FaceAttrInfo : AlipayObject
    {
        /// <summary>
        /// left,top,width,height 人脸图片中的人脸框的左上点和宽高，图片内坐标，无需脱敏
        /// </summary>
        [JsonPropertyName("rect")]
        public string Rect { get; set; }
    }
}
