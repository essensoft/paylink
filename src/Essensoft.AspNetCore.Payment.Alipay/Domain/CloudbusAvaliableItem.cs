using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CloudbusAvaliableItem Data Structure.
    /// </summary>
    [Serializable]
    public class CloudbusAvaliableItem : AlipayObject
    {
        /// <summary>
        /// 城市码
        /// </summary>
        [JsonProperty("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 结束可查月份  格式 yyyyMM
        /// </summary>
        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 最大geohash数量
        /// </summary>
        [JsonProperty("max_size")]
        public long MaxSize { get; set; }

        /// <summary>
        /// 起始可查月份
        /// </summary>
        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 城市是否有可用信息  true  false
        /// </summary>
        [JsonProperty("status")]
        public bool Status { get; set; }

        /// <summary>
        /// 已经用geohash 数量
        /// </summary>
        [JsonProperty("used_size")]
        public long UsedSize { get; set; }
    }
}
