using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppIndustryGovHealthcodeQueryModel Data Structure.
    /// </summary>
    public class AlipayEbppIndustryGovHealthcodeQueryModel : AlipayObject
    {
        /// <summary>
        /// 市
        /// </summary>
        [JsonPropertyName("city_code")]
        public string CityCode { get; set; }
    }
}
