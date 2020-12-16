using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// HomeAwayInfo Data Structure.
    /// </summary>
    public class HomeAwayInfo : AlipayObject
    {
        /// <summary>
        /// 客队数据
        /// </summary>
        [JsonPropertyName("away")]
        public long Away { get; set; }

        /// <summary>
        /// 主队数据
        /// </summary>
        [JsonPropertyName("home")]
        public long Home { get; set; }
    }
}
