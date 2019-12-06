using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingIbsInfo Data Structure.
    /// </summary>
    public class AlipayMarketingIbsInfo : AlipayObject
    {
        /// <summary>
        /// 精度
        /// </summary>
        [JsonPropertyName("accuracy")]
        public string Accuracy { get; set; }

        /// <summary>
        /// 海拔
        /// </summary>
        [JsonPropertyName("altitude")]
        public string Altitude { get; set; }

        /// <summary>
        /// 维度
        /// </summary>
        [JsonPropertyName("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [JsonPropertyName("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 时间ms
        /// </summary>
        [JsonPropertyName("time")]
        public string Time { get; set; }
    }
}
