using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TravelMallRequest Data Structure.
    /// </summary>
    public class TravelMallRequest : AlipayObject
    {
        /// <summary>
        /// 目的地距目标综合体的距离(单位:米)
        /// </summary>
        [JsonPropertyName("distance")]
        public long Distance { get; set; }

        /// <summary>
        /// 综合体ID
        /// </summary>
        [JsonPropertyName("mall_id")]
        public string MallId { get; set; }
    }
}
