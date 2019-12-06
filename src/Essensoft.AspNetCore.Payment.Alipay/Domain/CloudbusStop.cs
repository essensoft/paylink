using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CloudbusStop Data Structure.
    /// </summary>
    public class CloudbusStop : AlipayObject
    {
        /// <summary>
        /// 维度
        /// </summary>
        [JsonPropertyName("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [JsonPropertyName("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 站点id
        /// </summary>
        [JsonPropertyName("station_id")]
        public string StationId { get; set; }

        /// <summary>
        /// 站点名称
        /// </summary>
        [JsonPropertyName("station_name")]
        public string StationName { get; set; }

        /// <summary>
        /// 站点在线路内的序号
        /// </summary>
        [JsonPropertyName("station_num")]
        public long StationNum { get; set; }

        /// <summary>
        /// 站间距
        /// </summary>
        [JsonPropertyName("station_space")]
        public long StationSpace { get; set; }

        /// <summary>
        /// 站点客流
        /// </summary>
        [JsonPropertyName("station_volume")]
        public long StationVolume { get; set; }
    }
}
