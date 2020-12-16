using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayInsDataDiseaseIdentifyResponse.
    /// </summary>
    public class AlipayInsDataDiseaseIdentifyResponse : AlipayResponse
    {
        /// <summary>
        /// 疾病标准编码
        /// </summary>
        [JsonPropertyName("disease_code")]
        public string DiseaseCode { get; set; }

        /// <summary>
        /// 疾病标准名称
        /// </summary>
        [JsonPropertyName("disease_name")]
        public string DiseaseName { get; set; }

        /// <summary>
        /// 疾病标签
        /// </summary>
        [JsonPropertyName("disease_tag")]
        public string DiseaseTag { get; set; }
    }
}
