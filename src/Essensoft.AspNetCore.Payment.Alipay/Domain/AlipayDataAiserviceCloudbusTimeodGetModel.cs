using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusTimeodGetModel Data Structure.
    /// </summary>
    public class AlipayDataAiserviceCloudbusTimeodGetModel : AlipayObject
    {
        /// <summary>
        /// 接口版本
        /// </summary>
        [JsonPropertyName("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 市
        /// </summary>
        [JsonPropertyName("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 工作日和非工作日 枚举{WORKDAY,WEEKEND,ALL}
        /// </summary>
        [JsonPropertyName("date_type")]
        public string DateType { get; set; }

        /// <summary>
        /// 目的地 geohash
        /// </summary>
        [JsonPropertyName("dest_geo")]
        public string DestGeo { get; set; }

        /// <summary>
        /// 结束时间精确到月。例如201901
        /// </summary>
        [JsonPropertyName("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 起始区域 geohash list 。 区域必须连续，否则对结果有影响
        /// </summary>
        [JsonPropertyName("origin_geo_hashs")]
        public List<string> OriginGeoHashs { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [JsonPropertyName("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 开始时间 精确到月 例如：201904
        /// </summary>
        [JsonPropertyName("start_date")]
        public string StartDate { get; set; }
    }
}
