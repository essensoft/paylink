using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// HighwaySceneData Data Structure.
    /// </summary>
    public class HighwaySceneData : AlipayObject
    {
        /// <summary>
        /// 车辆类：  car:客车；  truck:货车
        /// </summary>
        [JsonPropertyName("car_type")]
        public string CarType { get; set; }

        /// <summary>
        /// 本交易出站省份，使用国家区域编码
        /// </summary>
        [JsonPropertyName("end_province_code")]
        public string EndProvinceCode { get; set; }

        /// <summary>
        /// 出站口服务方编码
        /// </summary>
        [JsonPropertyName("end_station_code")]
        public string EndStationCode { get; set; }

        /// <summary>
        /// 出站口ID
        /// </summary>
        [JsonPropertyName("end_station_id")]
        public string EndStationId { get; set; }

        /// <summary>
        /// 出站口纬度
        /// </summary>
        [JsonPropertyName("end_station_latitude")]
        public string EndStationLatitude { get; set; }

        /// <summary>
        /// 出站口经度
        /// </summary>
        [JsonPropertyName("end_station_longitude")]
        public string EndStationLongitude { get; set; }

        /// <summary>
        /// 出站口名称
        /// </summary>
        [JsonPropertyName("end_station_name")]
        public string EndStationName { get; set; }

        /// <summary>
        /// 出站口省份名称
        /// </summary>
        [JsonPropertyName("end_station_province")]
        public string EndStationProvince { get; set; }

        /// <summary>
        /// 即用户出高速时间
        /// </summary>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 收费车道编号
        /// </summary>
        [JsonPropertyName("lane_no")]
        public string LaneNo { get; set; }

        /// <summary>
        /// 本交易进站省份，使用国家区域编码
        /// </summary>
        [JsonPropertyName("start_province_code")]
        public string StartProvinceCode { get; set; }

        /// <summary>
        /// 进站口服务方编码
        /// </summary>
        [JsonPropertyName("start_station_code")]
        public string StartStationCode { get; set; }

        /// <summary>
        /// 进站口ID
        /// </summary>
        [JsonPropertyName("start_station_id")]
        public string StartStationId { get; set; }

        /// <summary>
        /// 进站口纬度
        /// </summary>
        [JsonPropertyName("start_station_latitude")]
        public string StartStationLatitude { get; set; }

        /// <summary>
        /// 进站口经度
        /// </summary>
        [JsonPropertyName("start_station_longitude")]
        public string StartStationLongitude { get; set; }

        /// <summary>
        /// 进站口名称
        /// </summary>
        [JsonPropertyName("start_station_name")]
        public string StartStationName { get; set; }

        /// <summary>
        /// 进站口省份名称
        /// </summary>
        [JsonPropertyName("start_station_province")]
        public string StartStationProvince { get; set; }

        /// <summary>
        /// 即用户进入高速时间
        /// </summary>
        [JsonPropertyName("start_time")]
        public string StartTime { get; set; }
    }
}
