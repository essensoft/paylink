using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SimpleMockModel Data Structure.
    /// </summary>
    public class SimpleMockModel : AlipayObject
    {
        /// <summary>
        /// 11
        /// </summary>
        [JsonPropertyName("count_items")]
        public long CountItems { get; set; }

        /// <summary>
        /// 111
        /// </summary>
        [JsonPropertyName("happen_time")]
        public string HappenTime { get; set; }

        /// <summary>
        /// 1.2f
        /// </summary>
        [JsonPropertyName("price_num")]
        public string PriceNum { get; set; }

        /// <summary>
        /// false
        /// </summary>
        [JsonPropertyName("right")]
        public bool Right { get; set; }

        /// <summary>
        /// trade_no
        /// </summary>
        [JsonPropertyName("trade_no")]
        public string TradeNo { get; set; }
    }
}
