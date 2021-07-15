using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// MedicalInsuredCityList Data Structure.
    /// </summary>
    public class MedicalInsuredCityList : AlipayObject
    {
        /// <summary>
        /// 参保地城市编码(国标)
        /// </summary>
        [JsonPropertyName("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 参保地城市编码(机构)
        /// </summary>
        [JsonPropertyName("ins_city_code")]
        public string InsCityCode { get; set; }

        /// <summary>
        /// 是否是默认参保地
        /// </summary>
        [JsonPropertyName("is_default_city")]
        public string IsDefaultCity { get; set; }
    }
}
