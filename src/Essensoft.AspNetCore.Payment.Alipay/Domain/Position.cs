using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Position Data Structure.
    /// </summary>
    public class Position : AlipayObject
    {
        /// <summary>
        /// 城市编码
        /// </summary>
        [JsonPropertyName("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 点位唯一标识id
        /// </summary>
        [JsonPropertyName("device_id")]
        public long DeviceId { get; set; }

        /// <summary>
        /// 屏幕类型，枚举值：SLCD、LED
        /// </summary>
        [JsonPropertyName("device_type")]
        public string DeviceType { get; set; }

        /// <summary>
        /// 公交 或者 地铁：SUBWAY、BUS
        /// </summary>
        [JsonPropertyName("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 站点编码
        /// </summary>
        [JsonPropertyName("station_code")]
        public string StationCode { get; set; }

        /// <summary>
        /// 站点等级，共分为4个等级，分别为：LEVELA、LEVLEB、LEVELC 以及 LEVELD
        /// </summary>
        [JsonPropertyName("station_level")]
        public string StationLevel { get; set; }
    }
}
