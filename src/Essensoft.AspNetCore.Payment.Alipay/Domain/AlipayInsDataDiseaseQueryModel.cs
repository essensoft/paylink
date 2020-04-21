using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsDataDiseaseQueryModel Data Structure.
    /// </summary>
    public class AlipayInsDataDiseaseQueryModel : AlipayObject
    {
        /// <summary>
        /// 疾病名称
        /// </summary>
        [JsonPropertyName("disease_name")]
        public string DiseaseName { get; set; }

        /// <summary>
        /// 分页使用，页码，1开始
        /// </summary>
        [JsonPropertyName("page_index")]
        public long PageIndex { get; set; }

        /// <summary>
        /// 页码大小，最大50
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }
    }
}
