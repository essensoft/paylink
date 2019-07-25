using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// HighwaySceneData Data Structure.
    /// </summary>
    [Serializable]
    public class HighwaySceneData : AlipayObject
    {
        /// <summary>
        /// 车辆类：  car:客车；  truck:货车
        /// </summary>
        [JsonProperty("car_type")]
        public string CarType { get; set; }

        /// <summary>
        /// 本交易出站省份，使用国家区域编码
        /// </summary>
        [JsonProperty("end_province_code")]
        public string EndProvinceCode { get; set; }

        /// <summary>
        /// 出站口服务方编码
        /// </summary>
        [JsonProperty("end_station_code")]
        public string EndStationCode { get; set; }

        /// <summary>
        /// 出站口ID
        /// </summary>
        [JsonProperty("end_station_id")]
        public string EndStationId { get; set; }

        /// <summary>
        /// 出站口纬度
        /// </summary>
        [JsonProperty("end_station_latitude")]
        public string EndStationLatitude { get; set; }

        /// <summary>
        /// 出站口经度
        /// </summary>
        [JsonProperty("end_station_longitude")]
        public string EndStationLongitude { get; set; }

        /// <summary>
        /// 出站口名称
        /// </summary>
        [JsonProperty("end_station_name")]
        public string EndStationName { get; set; }

        /// <summary>
        /// 出站口省份名称
        /// </summary>
        [JsonProperty("end_station_province")]
        public string EndStationProvince { get; set; }

        /// <summary>
        /// 即用户出高速时间
        /// </summary>
        [JsonProperty("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 收费车道编号
        /// </summary>
        [JsonProperty("lane_no")]
        public string LaneNo { get; set; }

        /// <summary>
        /// 本交易进站省份，使用国家区域编码
        /// </summary>
        [JsonProperty("start_province_code")]
        public string StartProvinceCode { get; set; }

        /// <summary>
        /// 进站口服务方编码
        /// </summary>
        [JsonProperty("start_station_code")]
        public string StartStationCode { get; set; }

        /// <summary>
        /// 进站口ID
        /// </summary>
        [JsonProperty("start_station_id")]
        public string StartStationId { get; set; }

        /// <summary>
        /// 进站口纬度
        /// </summary>
        [JsonProperty("start_station_latitude")]
        public string StartStationLatitude { get; set; }

        /// <summary>
        /// 进站口经度
        /// </summary>
        [JsonProperty("start_station_longitude")]
        public string StartStationLongitude { get; set; }

        /// <summary>
        /// 进站口名称
        /// </summary>
        [JsonProperty("start_station_name")]
        public string StartStationName { get; set; }

        /// <summary>
        /// 进站口省份名称
        /// </summary>
        [JsonProperty("start_station_province")]
        public string StartStationProvince { get; set; }

        /// <summary>
        /// 即用户进入高速时间
        /// </summary>
        [JsonProperty("start_time")]
        public string StartTime { get; set; }
    }
}
