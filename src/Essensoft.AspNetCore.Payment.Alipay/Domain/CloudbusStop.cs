using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CloudbusStop Data Structure.
    /// </summary>
    [Serializable]
    public class CloudbusStop : AlipayObject
    {
        /// <summary>
        /// 维度
        /// </summary>
        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 站点id
        /// </summary>
        [JsonProperty("station_id")]
        public string StationId { get; set; }

        /// <summary>
        /// 站点名称
        /// </summary>
        [JsonProperty("station_name")]
        public string StationName { get; set; }

        /// <summary>
        /// 站点在线路内的序号
        /// </summary>
        [JsonProperty("station_num")]
        public long StationNum { get; set; }

        /// <summary>
        /// 站间距
        /// </summary>
        [JsonProperty("station_space")]
        public long StationSpace { get; set; }

        /// <summary>
        /// 站点客流
        /// </summary>
        [JsonProperty("station_volume")]
        public long StationVolume { get; set; }
    }
}
