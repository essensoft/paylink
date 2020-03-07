using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CloudbusAvaliableItem Data Structure.
    /// </summary>
    public class CloudbusAvaliableItem : AlipayObject
    {
        /// <summary>
        /// 城市码
        /// </summary>
        [JsonPropertyName("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 结束可查月份  格式 yyyyMM
        /// </summary>
        [JsonPropertyName("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 最大geohash数量
        /// </summary>
        [JsonPropertyName("max_size")]
        public long MaxSize { get; set; }

        /// <summary>
        /// 起始可查月份
        /// </summary>
        [JsonPropertyName("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 城市是否有可用信息  true  false
        /// </summary>
        [JsonPropertyName("status")]
        public bool Status { get; set; }

        /// <summary>
        /// 已经用geohash 数量
        /// </summary>
        [JsonPropertyName("used_size")]
        public long UsedSize { get; set; }
    }
}
