using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsDataHospitalQueryModel Data Structure.
    /// </summary>
    public class AlipayInsDataHospitalQueryModel : AlipayObject
    {
        /// <summary>
        /// 医院所在的地市名称
        /// </summary>
        [JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// 医院名称
        /// </summary>
        [JsonPropertyName("hospital_name")]
        public string HospitalName { get; set; }
    }
}
