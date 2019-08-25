using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusOdGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataAiserviceCloudbusOdGetModel : AlipayObject
    {
        /// <summary>
        /// 接口版本
        /// </summary>
        [JsonProperty("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 市
        /// </summary>
        [JsonProperty("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 工作日和非工作日 枚举{WORKDAY,WEEKEND,ALL}
        /// </summary>
        [JsonProperty("date_type")]
        public string DateType { get; set; }

        /// <summary>
        /// 结束时间精确到月。例如201901
        /// </summary>
        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 起始区域 geohash list 。 区域必须连续，否则对结果有影响
        /// </summary>
        [JsonProperty("origin_geo_hashs")]
        public List<string> OriginGeoHashs { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [JsonProperty("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 开始时间 精确到月 例如：201904
        /// </summary>
        [JsonProperty("start_date")]
        public string StartDate { get; set; }
    }
}
