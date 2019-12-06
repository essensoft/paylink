using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// VehicleInfo Data Structure.
    /// </summary>
    public class VehicleInfo : AlipayObject
    {
        /// <summary>
        /// 保险公司ID
        /// </summary>
        [JsonPropertyName("company_id")]
        public string CompanyId { get; set; }

        /// <summary>
        /// 保险公司对应的精友码（转码）
        /// </summary>
        [JsonPropertyName("vehicle_code")]
        public string VehicleCode { get; set; }

        /// <summary>
        /// 精友码提供者在精友的主体编码
        /// </summary>
        [JsonPropertyName("vehicle_subject_code")]
        public string VehicleSubjectCode { get; set; }
    }
}
