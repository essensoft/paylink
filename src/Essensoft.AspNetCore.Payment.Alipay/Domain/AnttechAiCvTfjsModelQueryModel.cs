using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AnttechAiCvTfjsModelQueryModel Data Structure.
    /// </summary>
    public class AnttechAiCvTfjsModelQueryModel : AlipayObject
    {
        /// <summary>
        /// 模型服务code，模型服务唯一标示
        /// </summary>
        [JsonPropertyName("model_code")]
        public string ModelCode { get; set; }

        /// <summary>
        /// 模型对应版本号
        /// </summary>
        [JsonPropertyName("model_version")]
        public string ModelVersion { get; set; }
    }
}
