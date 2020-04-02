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
    }
}
