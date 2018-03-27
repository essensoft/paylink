using Newtonsoft.Json;

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
        [JsonProperty("accuracy")]
        public string Accuracy { get; set; }

        /// <summary>
        /// 海拔
        /// </summary>
        [JsonProperty("altitude")]
        public string Altitude { get; set; }

        /// <summary>
        /// 维度
        /// </summary>
        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 时间ms
        /// </summary>
        [JsonProperty("time")]
        public string Time { get; set; }
    }
}
