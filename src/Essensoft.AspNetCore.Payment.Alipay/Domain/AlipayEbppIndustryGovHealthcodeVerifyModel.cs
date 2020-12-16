using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppIndustryGovHealthcodeVerifyModel Data Structure.
    /// </summary>
    public class AlipayEbppIndustryGovHealthcodeVerifyModel : AlipayObject
    {
        /// <summary>
        /// 市
        /// </summary>
        [JsonPropertyName("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 扫描或查询到的健康码码值
        /// </summary>
        [JsonPropertyName("code_content")]
        public string CodeContent { get; set; }

        /// <summary>
        /// 区分验码的业务主体，医护天使: MEDICAL_ANGEL; 默认为健康码: HEALTH_CODE
        /// </summary>
        [JsonPropertyName("industry_type")]
        public string IndustryType { get; set; }
    }
}
