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
        /// 当具体交易场景为ETC_HIGHWAY、ETC_HIGHWAY_OPEN时，该字段必填，格式为省份+收费站名，比如“黑龙江瓦盆窑西站”
        /// </summary>
        [JsonPropertyName("end_station_name")]
        public string EndStationName { get; set; }

        /// <summary>
        /// 出站口省份名称
        /// </summary>
        [JsonPropertyName("end_station_province")]
        public string EndStationProvince { get; set; }

        /// <summary>
        /// 对应路网规范中的chargeTime字段，如果是高速通行场景，该字段为高速出口的时间
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
        /// 当具体交易场景为ETC_HIGHWAY时，该字段必填，格式为省份+收费站名，比如“黑龙江瓦盆窑西站”
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

        /// <summary>
        /// 子场景： ETC_HIGHWAY：ETC封闭式高速公路（不传默认这个值）； ETC_HIGHWAY_OPEN：ETC开放式高速公路； ETC_PARKING：ETC停车场； ETC_GAS：ETC加油站； ETC_SERVICE_AREA：ETC服务区； ETC_MUNICIPAL_SERVICE：ETC市政服务。
        /// </summary>
        [JsonPropertyName("sub_scene")]
        public string SubScene { get; set; }

        /// <summary>
        /// 1、当交易场景为ETC_PARKING时：省份+停车场描述 (停车场描述应填写停车场名称 或停车场具体地点，勿填停车场 所属公司名称)，如北京市首都机场停车场/北京市东城区东单体育馆南侧路停车场 2、当交易场景为ETC_GAS时：省份+加油站描述 (加油站描述应填写加油站具体 地点)，比如北京市朝阳区北四环东路中石化加油站 3、当交易场景为ETC_SERVICE_AREA时：省份+服务区描述 (服务区描述应填写所在高速公 路名称及服务区名称)，如北京市京藏高速百葛服务区 4、当交易场景为ETC_MUNICIPAL_SERVICE时：省份+市政服务 描述(市政服务描述应填写市政 服务名称)，比如山东省青岛市胶州湾海底隧道
        /// </summary>
        [JsonPropertyName("sub_scene_desc")]
        public string SubSceneDesc { get; set; }

        /// <summary>
        /// HIGHWAY_TYPE：高速交易场景类型，对应具体交易场景[ETC_HIGHWAY,ETC_HIGHWAY_OPEN] EXPAND_TYPE：拓展消费交易类型，对应具体交易场景 [ETC_PARKING,ETC_GAS,ETC_SERVICE_AREA,ETC_MUNICIPAL_SERVICE]
        /// </summary>
        [JsonPropertyName("sub_type")]
        public string SubType { get; set; }
    }
}
