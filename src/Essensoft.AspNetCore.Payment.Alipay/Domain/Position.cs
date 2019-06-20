using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Position Data Structure.
    /// </summary>
    [Serializable]
    public class Position : AlipayObject
    {
        /// <summary>
        /// 城市编码
        /// </summary>
        [JsonProperty("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 点位唯一标识id
        /// </summary>
        [JsonProperty("device_id")]
        public long DeviceId { get; set; }

        /// <summary>
        /// 屏幕类型，枚举值：SLCD、LED
        /// </summary>
        [JsonProperty("device_type")]
        public string DeviceType { get; set; }

        /// <summary>
        /// 公交 或者 地铁：SUBWAY、BUS
        /// </summary>
        [JsonProperty("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 站点编码
        /// </summary>
        [JsonProperty("station_code")]
        public string StationCode { get; set; }

        /// <summary>
        /// 站点等级，共分为4个等级，分别为：LEVELA、LEVLEB、LEVELC 以及 LEVELD
        /// </summary>
        [JsonProperty("station_level")]
        public string StationLevel { get; set; }
    }
}
