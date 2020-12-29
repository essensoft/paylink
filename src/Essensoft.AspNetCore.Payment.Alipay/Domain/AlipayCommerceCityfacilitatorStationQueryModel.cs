using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceCityfacilitatorStationQueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceCityfacilitatorStationQueryModel : AlipayObject
    {
        /// <summary>
        /// 城市编码为城市行政代码。 已支持城市：广州 440100，深圳 440300，杭州330100。
        /// </summary>
        [JsonPropertyName("city_code")]
        public string CityCode { get; set; }
    }
}
