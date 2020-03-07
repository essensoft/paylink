using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DiseaseDTO Data Structure.
    /// </summary>
    public class DiseaseDTO : AlipayObject
    {
        /// <summary>
        /// 疾病标准编码
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// 疾病标准名称
        /// </summary>
        [JsonPropertyName("disease_name")]
        public string DiseaseName { get; set; }
    }
}
