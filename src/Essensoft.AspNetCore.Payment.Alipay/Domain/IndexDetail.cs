using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// IndexDetail Data Structure.
    /// </summary>
    [Serializable]
    public class IndexDetail : AlipayObject
    {
        /// <summary>
        /// 区域编码
        /// </summary>
        [JsonProperty("area_code")]
        public string AreaCode { get; set; }

        /// <summary>
        /// 区域名称
        /// </summary>
        [JsonProperty("area_name")]
        public string AreaName { get; set; }

        /// <summary>
        /// 当月市排名
        /// </summary>
        [JsonProperty("city_ranking")]
        public string CityRanking { get; set; }

        /// <summary>
        /// 当月区排名
        /// </summary>
        [JsonProperty("county_ranking")]
        public string CountyRanking { get; set; }

        /// <summary>
        /// 主键
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// 指数值
        /// </summary>
        [JsonProperty("index_val")]
        public string IndexVal { get; set; }

        /// <summary>
        /// 年月
        /// </summary>
        [JsonProperty("period")]
        public string Period { get; set; }
    }
}
