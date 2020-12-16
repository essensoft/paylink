using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PrizeOrderVO Data Structure.
    /// </summary>
    public class PrizeOrderVO : AlipayObject
    {
        /// <summary>
        /// 发奖系数。
        /// </summary>
        [JsonPropertyName("modulus")]
        public long Modulus { get; set; }

        /// <summary>
        /// 返奖奖品ID。
        /// </summary>
        [JsonPropertyName("prize_id")]
        public string PrizeId { get; set; }

        /// <summary>
        /// 奖品名称。
        /// </summary>
        [JsonPropertyName("prize_name")]
        public string PrizeName { get; set; }

        /// <summary>
        /// 发奖单据ID
        /// </summary>
        [JsonPropertyName("prize_order_id")]
        public string PrizeOrderId { get; set; }

        /// <summary>
        /// 返奖奖品类型。
        /// </summary>
        [JsonPropertyName("prize_type")]
        public string PrizeType { get; set; }
    }
}
