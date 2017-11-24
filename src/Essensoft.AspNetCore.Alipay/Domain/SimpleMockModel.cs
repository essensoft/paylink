using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// SimpleMockModel Data Structure.
    /// </summary>
    public class SimpleMockModel : AlipayObject
    {
        /// <summary>
        /// 11
        /// </summary>
        [JsonProperty("count_items")]
        public long CountItems { get; set; }

        /// <summary>
        /// 111
        /// </summary>
        [JsonProperty("happen_time")]
        public string HappenTime { get; set; }

        /// <summary>
        /// 1.2f
        /// </summary>
        [JsonProperty("price_num")]
        public string PriceNum { get; set; }

        /// <summary>
        /// false
        /// </summary>
        [JsonProperty("right")]
        public bool Right { get; set; }

        /// <summary>
        /// trade_no
        /// </summary>
        [JsonProperty("trade_no")]
        public string TradeNo { get; set; }
    }
}
