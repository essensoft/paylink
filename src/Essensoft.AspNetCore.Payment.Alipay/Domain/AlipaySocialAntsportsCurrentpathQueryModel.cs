using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySocialAntsportsCurrentpathQueryModel Data Structure.
    /// </summary>
    public class AlipaySocialAntsportsCurrentpathQueryModel : AlipayObject
    {
        /// <summary>
        /// 日期。格式yyyy-MM-dd
        /// </summary>
        [JsonPropertyName("day")]
        public string Day { get; set; }

        /// <summary>
        /// 路线场景
        /// </summary>
        [JsonPropertyName("path_scene")]
        public string PathScene { get; set; }

        /// <summary>
        /// 路线归属站点编码
        /// </summary>
        [JsonPropertyName("path_station_code")]
        public string PathStationCode { get; set; }

        /// <summary>
        /// 路线归属站点名称
        /// </summary>
        [JsonPropertyName("path_station_name")]
        public string PathStationName { get; set; }

        /// <summary>
        /// 时区
        /// </summary>
        [JsonPropertyName("time_zone")]
        public string TimeZone { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
