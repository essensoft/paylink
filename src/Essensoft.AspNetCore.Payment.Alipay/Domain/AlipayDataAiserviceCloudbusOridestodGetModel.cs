using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusOridestodGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataAiserviceCloudbusOridestodGetModel : AlipayObject
    {
        /// <summary>
        /// 内部接口版本号
        /// </summary>
        [JsonProperty("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 市
        /// </summary>
        [JsonProperty("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 目的geo 列表
        /// </summary>
        [JsonProperty("dest_geo")]
        public List<string> DestGeo { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 起始geohash
        /// </summary>
        [JsonProperty("ori_geo")]
        public List<string> OriGeo { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [JsonProperty("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonProperty("start_date")]
        public string StartDate { get; set; }
    }
}
