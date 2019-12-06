using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AftAifinFireeyeOcrImageQueryModel Data Structure.
    /// </summary>
    public class AftAifinFireeyeOcrImageQueryModel : AlipayObject
    {
        /// <summary>
        /// 用于ocr识别请求图片的BASE64编码
        /// </summary>
        [JsonPropertyName("image")]
        public string Image { get; set; }

        /// <summary>
        /// ocr服务类型，例如银行卡bankcard, 营业执照businesslicense, 车架号carvin, 驾驶证driverlicense, 行驶证vehiclelicense, 身份证idcard, 车牌号vehicleplate, 发票inference等
        /// </summary>
        [JsonPropertyName("ocr_type")]
        public string OcrType { get; set; }

        /// <summary>
        /// 产品集群ID，默认填写示例值
        /// </summary>
        [JsonPropertyName("product_instance_id")]
        public string ProductInstanceId { get; set; }
    }
}
