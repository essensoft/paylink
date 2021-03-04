using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AftAifinFireeyeOcrImageQueryResponse.
    /// </summary>
    public class AftAifinFireeyeOcrImageQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 识别结果字段，这个是一个JSON字符串
        /// </summary>
        [JsonPropertyName("content")]
        public OcrIdentifyResult Content { get; set; }
    }
}
