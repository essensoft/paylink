using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// LoanPayInstallment Data Structure.
    /// </summary>
    public class LoanPayInstallment : AlipayObject
    {
        /// <summary>
        /// 摘要要素，为JSON大字段
        /// </summary>
        [JsonPropertyName("base_element")]
        public string BaseElement { get; set; }

        /// <summary>
        /// 分期要素详情，为JSON大字段
        /// </summary>
        [JsonPropertyName("details_element")]
        public string DetailsElement { get; set; }

        /// <summary>
        /// 扩展要素，为JSONArray大字段
        /// </summary>
        [JsonPropertyName("extends_element")]
        public string ExtendsElement { get; set; }

        /// <summary>
        /// 分期id
        /// </summary>
        [JsonPropertyName("installment_id")]
        public string InstallmentId { get; set; }
    }
}
