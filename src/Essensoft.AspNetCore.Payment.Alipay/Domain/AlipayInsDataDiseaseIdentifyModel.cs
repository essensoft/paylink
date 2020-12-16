using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsDataDiseaseIdentifyModel Data Structure.
    /// </summary>
    public class AlipayInsDataDiseaseIdentifyModel : AlipayObject
    {
        /// <summary>
        /// 疾病处理操作，例如标化(STANDARD)、打标(TAG)
        /// </summary>
        [JsonPropertyName("action_type")]
        public string ActionType { get; set; }

        /// <summary>
        /// 疾病名称
        /// </summary>
        [JsonPropertyName("disease_name")]
        public string DiseaseName { get; set; }
    }
}
