using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// EduWorkAddress Data Structure.
    /// </summary>
    public class EduWorkAddress : AlipayObject
    {
        /// <summary>
        /// 地址
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        [JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// 区
        /// </summary>
        [JsonPropertyName("district_name")]
        public string DistrictName { get; set; }

        /// <summary>
        /// 北京市
        /// </summary>
        [JsonPropertyName("province")]
        public string Province { get; set; }

        /// <summary>
        /// 街道
        /// </summary>
        [JsonPropertyName("street_name")]
        public string StreetName { get; set; }
    }
}
