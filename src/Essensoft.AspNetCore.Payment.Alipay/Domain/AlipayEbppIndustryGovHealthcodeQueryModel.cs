using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppIndustryGovHealthcodeQueryModel Data Structure.
    /// </summary>
    public class AlipayEbppIndustryGovHealthcodeQueryModel : AlipayObject
    {
        /// <summary>
        /// json格式的业务相关信息, 因健康码不同的省市存在个性化的业务参数需求，在本字段内传入
        /// </summary>
        [JsonPropertyName("biz_info")]
        public string BizInfo { get; set; }

        /// <summary>
        /// 业务类型，医护天使码: MEDIC_ANGEL; 健康码: HEALTHCODE。为空时默认为健康码HEALTHCODE
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 市
        /// </summary>
        [JsonPropertyName("city_code")]
        public string CityCode { get; set; }
    }
}
