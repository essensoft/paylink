using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoRenthouseCommunityBaseinfoSyncModel Data Structure.
    /// </summary>
    public class AlipayEcoRenthouseCommunityBaseinfoSyncModel : AlipayObject
    {
        /// <summary>
        /// 商圈编码
        /// </summary>
        [JsonPropertyName("bus_code")]
        public string BusCode { get; set; }

        /// <summary>
        /// 商圈所在纬度
        /// </summary>
        [JsonPropertyName("bus_lat")]
        public string BusLat { get; set; }

        /// <summary>
        /// 商圈所在经度
        /// </summary>
        [JsonPropertyName("bus_lng")]
        public string BusLng { get; set; }

        /// <summary>
        /// 商圈名称
        /// </summary>
        [JsonPropertyName("bus_name")]
        public string BusName { get; set; }

        /// <summary>
        /// 商圈覆盖半径(单位:米)
        /// </summary>
        [JsonPropertyName("bus_radius")]
        public long BusRadius { get; set; }

        /// <summary>
        /// 城市编码
        /// </summary>
        [JsonPropertyName("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 城市所在纬度
        /// </summary>
        [JsonPropertyName("city_lat")]
        public string CityLat { get; set; }

        /// <summary>
        /// 城市所在经度
        /// </summary>
        [JsonPropertyName("city_lng")]
        public string CityLng { get; set; }

        /// <summary>
        /// 城市名称
        /// </summary>
        [JsonPropertyName("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 小区/大楼编码
        /// </summary>
        [JsonPropertyName("community_code")]
        public string CommunityCode { get; set; }

        /// <summary>
        /// 小区/大楼所在纬度
        /// </summary>
        [JsonPropertyName("community_lat")]
        public string CommunityLat { get; set; }

        /// <summary>
        /// 小区/大楼所在经度
        /// </summary>
        [JsonPropertyName("community_lng")]
        public string CommunityLng { get; set; }

        /// <summary>
        /// 小区/大楼名称
        /// </summary>
        [JsonPropertyName("community_name")]
        public string CommunityName { get; set; }

        /// <summary>
        /// 小区/大楼弄号
        /// </summary>
        [JsonPropertyName("community_nong")]
        public string CommunityNong { get; set; }

        /// <summary>
        /// 小区/大楼街道
        /// </summary>
        [JsonPropertyName("community_street")]
        public string CommunityStreet { get; set; }

        /// <summary>
        /// 小区/大楼标识类型 1：小区  2:大楼
        /// </summary>
        [JsonPropertyName("community_tag")]
        public string CommunityTag { get; set; }

        /// <summary>
        /// 行政区域编码
        /// </summary>
        [JsonPropertyName("district_code")]
        public string DistrictCode { get; set; }

        /// <summary>
        /// 行政区域所在纬度
        /// </summary>
        [JsonPropertyName("district_lat")]
        public string DistrictLat { get; set; }

        /// <summary>
        /// 行政区域所在经度
        /// </summary>
        [JsonPropertyName("district_lng")]
        public string DistrictLng { get; set; }

        /// <summary>
        /// 行政区域名称
        /// </summary>
        [JsonPropertyName("district_name")]
        public string DistrictName { get; set; }

        /// <summary>
        /// 地铁线地铁站关系
        /// </summary>
        [JsonPropertyName("subway_stations")]
        public List<string> SubwayStations { get; set; }
    }
}
