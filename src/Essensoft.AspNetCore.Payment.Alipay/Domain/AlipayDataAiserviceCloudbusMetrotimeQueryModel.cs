using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusMetrotimeQueryModel Data Structure.
    /// </summary>
    public class AlipayDataAiserviceCloudbusMetrotimeQueryModel : AlipayObject
    {
        /// <summary>
        /// 接口版本号
        /// </summary>
        [JsonPropertyName("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 市
        /// </summary>
        [JsonPropertyName("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 6位目的地geohash
        /// </summary>
        [JsonPropertyName("dest_geo")]
        public string DestGeo { get; set; }

        /// <summary>
        /// 结束年月
        /// </summary>
        [JsonPropertyName("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 进出站 0：进站  1：出站
        /// </summary>
        [JsonPropertyName("is_out")]
        public long IsOut { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [JsonPropertyName("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 开始年月
        /// </summary>
        [JsonPropertyName("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 地铁站名称
        /// </summary>
        [JsonPropertyName("station_id")]
        public string StationId { get; set; }

        /// <summary>
        /// 操作类型： 0：普通（默认）  1：潜在
        /// </summary>
        [JsonPropertyName("type")]
        public long Type { get; set; }
    }
}
