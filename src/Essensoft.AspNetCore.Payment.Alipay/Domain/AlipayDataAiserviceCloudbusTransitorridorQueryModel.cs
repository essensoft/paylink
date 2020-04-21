using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusTransitorridorQueryModel Data Structure.
    /// </summary>
    public class AlipayDataAiserviceCloudbusTransitorridorQueryModel : AlipayObject
    {
        /// <summary>
        /// 接口版本控制
        /// </summary>
        [JsonPropertyName("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 市
        /// </summary>
        [JsonPropertyName("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 结束时间， 可空，空代表到最近一个月
        /// </summary>
        [JsonPropertyName("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [JsonPropertyName("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 起始月份，<空>代表最早一个月
        /// </summary>
        [JsonPropertyName("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 枚举值。空（默认）：所有  0: 公共出行   1: 不包含地铁  2: 现有线网
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
